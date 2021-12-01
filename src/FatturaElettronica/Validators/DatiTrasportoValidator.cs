﻿using FluentValidation;
using FatturaElettronica.Ordinaria.FatturaElettronicaBody.DatiGenerali;
using FatturaElettronica.Tabelle;

namespace FatturaElettronica.Validators
{
    public class DatiTrasportoValidator : AbstractValidator<DatiTrasporto>
    {
        public DatiTrasportoValidator()
        {
            RuleFor(x => x.DatiAnagraficiVettore)
                .SetValidator(new DatiAnagraficiVettoreValidator())
                .When(x => x.DatiAnagraficiVettore != null && !x.DatiAnagraficiVettore.IsEmpty());
            RuleFor(x => x.MezzoTrasporto)
                .Length(1, 80)
                .Latin1SupplementValidator()
                .When(x => !string.IsNullOrEmpty(x.MezzoTrasporto));
            RuleFor(x => x.CausaleTrasporto)
                .Length(1, 100)
                .Latin1SupplementValidator()
                .When(x => !string.IsNullOrEmpty(x.CausaleTrasporto));
            RuleFor(x => x.Descrizione)
                .Length(1, 100)
                .Latin1SupplementValidator()
                .When(x => !string.IsNullOrEmpty(x.Descrizione));
            RuleFor(x => x.UnitaMisuraPeso)
                .Length(1, 10)
                .BasicLatinValidator()
                .When(x => !string.IsNullOrEmpty(x.UnitaMisuraPeso));
            RuleFor(x => x.TipoResa)
                .SetValidator(new IsValidValidator<DatiTrasporto, string, TipoResa>())
                .When(x => !string.IsNullOrEmpty(x.TipoResa));
            RuleFor(x => x.IndirizzoResa)
                .SetValidator(new IndirizzoResaValidator())
                .When(x => x.IndirizzoResa != null && !x.IndirizzoResa.IsEmpty());
            RuleFor(x => x.PesoLordo)
                .LessThanOrEqualTo(9999.99m);
            RuleFor(x => x.PesoNetto)
                .LessThanOrEqualTo(9999.99m);
        }
    }
}