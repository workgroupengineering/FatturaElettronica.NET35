// FatturaElettronica.Extensions.Resources.ErrorMessages

using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FatturaElettronica.Extensions.Resources
{
    internal class ErrorMessages : Dictionary<string, string>
    {
        private static readonly ErrorMessages dictionary;

        internal static string FirmaException
        {
            get
            {
                dictionary.TryGetValue(nameof(FirmaException), out var result);
                return result;
            }
        }

        internal static string IdCodiceIsMissing
        {
            get
            {
                dictionary.TryGetValue(nameof(IdCodiceIsMissing), out var result);
                return result;
            }
        }

        internal static string IdFiscaleIsMissing
        {
            get
            {
                dictionary.TryGetValue(nameof(IdFiscaleIsMissing), out var result);
                return result;
            }
        }

        internal static string IdPaeseIsWrongOrMissing
        {
            get
            {
                dictionary.TryGetValue(nameof(IdPaeseIsWrongOrMissing), out var result);
                return result;
            }
        }

        internal static string LastBillingNumberIsTooLong
        {
            get
            {
                dictionary.TryGetValue(nameof(LastBillingNumberIsTooLong), out var result);
                return result;
            }
        }

        internal static string PfxIsMissing
        {
            get
            {
                dictionary.TryGetValue(nameof(PfxIsMissing), out var result);
                return result;
            }
        }

        internal static string SignatureException
        {
            get
            {
                dictionary.TryGetValue(nameof(SignatureException), out var result);
                return result;
            }
        }

        static ErrorMessages()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (Stream source = typeof(ErrorMessages).Assembly.GetManifestResourceStream("FatturaElettronica.Extensions.Resources.ErrorMessages.json"))
            {
                using (StreamReader streamReader = new StreamReader(source))
                {
                    using (JsonTextReader reader = new JsonTextReader(streamReader))
                    {
                        dictionary = serializer.Deserialize<ErrorMessages>(reader);
                    }
                }
            }
        }
    }
}
