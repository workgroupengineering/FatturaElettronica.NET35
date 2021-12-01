using System;
#if NET35
using System.Linq;
#endif
using System.Collections.Generic;
using FatturaElettronica.Tabelle;
using FluentValidation;
using FluentValidation.Validators;

namespace FatturaElettronica.Validators
{
    public class IsValidValidator<T, TProperty, TTabella> : PropertyValidator<T, TProperty>
        where TTabella : Tabella, new()
    {
        private static readonly Lazy<TTabella> DomainObjectLazy = new(() => new());

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return "'{PropertyName}' valori accettati: {AcceptedValues}";
        }

        public override bool IsValid(ValidationContext<T> context, TProperty value)
        {
#if NET35
            context.MessageFormatter.AppendArgument("AcceptedValues", string.Format(string.Join(", ", Domain.ToArray())));
#else
            context.MessageFormatter.AppendArgument("AcceptedValues", string.Format(string.Join(", ", Domain)));
#endif

            if (value is string codice)
                return Domain.Contains(codice);

            return false;
        }

        private static HashSet<string> Domain
        {
            get { return DomainObjectLazy.Value.Codici; }
        }

        public override string Name => "IsValidValidator";
    }
}
