﻿using System;
using System.Collections.Generic;
using System.Linq;
using FatturaElettronica.Ordinaria.FatturaElettronicaBody;
using FluentValidation;

namespace FatturaElettronica.Validators
{
    public class FatturaElettronicaBodyValidator : AbstractValidator<FatturaElettronicaBody>
    {
        public FatturaElettronicaBodyValidator()
        {
            RuleFor(x => x.DatiGenerali)
                .SetValidator(new DatiGeneraliValidator());
            RuleFor(x => x.DatiBeniServizi)
                .SetValidator(new DatiBeniServiziValidator());
            RuleFor(x => x.DatiBeniServizi)
                .Must(x => !x.IsEmpty()).WithMessage("DatiBeniServizi è obbligatorio");
            RuleFor(x => x.DatiGenerali.DatiGeneraliDocumento.DatiRitenuta)
                .Must((body, _) => DatiRitenutaAgainstDettaglioLinee(body))
                .When(x => x.DatiGenerali.DatiGeneraliDocumento.DatiRitenuta.Count == 0)
                .WithMessage(
                    "DatiRitenuta non presente a fronte di almeno un blocco DettaglioLinee con Ritenuta uguale a SI")
                .WithErrorCode("00411");
            RuleFor(x => x.DatiBeniServizi.DatiRiepilogo)
                .Must((body, _) => DatiRiepilogoValidateAgainstError00422(body))
                .WithMessage("ImponibileImporto non calcolato secondo le specifiche tecniche")
                .WithErrorCode("00422");
            RuleFor(x => x.DatiBeniServizi.DatiRiepilogo)
                .Must((body, _) => DatiRiepilogoValidateAgainstError00419(body))
                .WithMessage(
                    "DatiRiepilogo non presente in corrispondenza di almeno un valore DettaglioLinee.AliquiotaIVA o DatiCassaPrevidenziale.AliquotaIVA")
                .WithErrorCode("00419");
            RuleFor(x => x.DatiGenerali.DatiGeneraliDocumento.TipoDocumento)
                .Must((body, _) => body.DatiBeniServizi.DettaglioLinee.All(linea => linea.AliquotaIVA != 0))
                .When(x => x.DatiGenerali.DatiGeneraliDocumento.TipoDocumento == "TD21")
                .WithMessage("Nel tipo documento ‘autofattura per splafonamento’ tutte le linee di dettaglio devo avere un’aliquota IVA diversa da zero")
                .WithErrorCode("00474");
            RuleFor(x => x.DatiVeicoli)
                .SetValidator(new DatiVeicoliValidator())
                .When(x => x.DatiVeicoli != null && !x.DatiVeicoli.IsEmpty());
            RuleForEach(x => x.DatiPagamento)
                .SetValidator(new DatiPagamentoValidator());
            RuleForEach(x => x.Allegati)
                .SetValidator(new AllegatiValidator());
        }

        private static bool DatiRitenutaAgainstDettaglioLinee(FatturaElettronicaBody body)
        {
            return body.DatiBeniServizi.DettaglioLinee.All(linea => linea.Ritenuta != "SI");
        }

        private static bool DatiRiepilogoValidateAgainstError00422(FatturaElettronicaBody body)
        {
            var totals = new Dictionary<decimal, Totals>();

            foreach (var r in body.DatiBeniServizi.DatiRiepilogo)
            {
                if (!totals.ContainsKey(r.AliquotaIVA))
                    totals.Add(r.AliquotaIVA, new());

                totals[r.AliquotaIVA].ImponibileImporto += r.ImponibileImporto;
                totals[r.AliquotaIVA].Arrotondamento += r.Arrotondamento ?? 0;
            }

            foreach (var l in body.DatiBeniServizi.DettaglioLinee)
            {
                if (!totals.ContainsKey(l.AliquotaIVA))
                    totals.Add(l.AliquotaIVA, new());

                totals[l.AliquotaIVA].PrezzoTotale += l.PrezzoTotale;
            }

            foreach (var c in body.DatiGenerali.DatiGeneraliDocumento.DatiCassaPrevidenziale)
            {
                if (!totals.ContainsKey(c.AliquotaIVA))
                    totals.Add(c.AliquotaIVA, new());

                totals[c.AliquotaIVA].ImportoContrCassa += c.ImportoContributoCassa;
            }

            return totals.Values.All(t => Math.Abs(t.ImponibileImporto - (t.PrezzoTotale + t.ImportoContrCassa + t.Arrotondamento)) < 1);
        }

        private static bool DatiRiepilogoValidateAgainstError00419(FatturaElettronicaBody body)
        {
            var hash = new HashSet<decimal>();
            foreach (var cp in body.DatiGenerali.DatiGeneraliDocumento.DatiCassaPrevidenziale.Where(cp => !hash.Contains(cp.AliquotaIVA)))
                hash.Add(cp.AliquotaIVA);

            foreach (var l in body.DatiBeniServizi.DettaglioLinee.Where(l => !hash.Contains(l.AliquotaIVA)))
                hash.Add(l.AliquotaIVA);

            return body.DatiBeniServizi.DatiRiepilogo.Count >= hash.Count;
        }

        private class Totals
        {
            public decimal ImponibileImporto;
            public decimal PrezzoTotale;
            public decimal Arrotondamento;
            public decimal ImportoContrCassa;
        }
    }
}