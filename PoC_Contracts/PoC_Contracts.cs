using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace PoC_Contracts
{
    [ContractClass(typeof(ICaseConverterContracts))]
    public interface ICaseConverter
    {
        string Convert(string text);
    }

    [ContractClassFor(typeof(ICaseConverter))]
    internal sealed class ICaseConverterContracts : ICaseConverter
    {
        string ICaseConverter.Convert(string text)
        {
            Contract.Requires<ArgumentNullException>(text != null, "Contract message: couldn't be null.");
    
            Contract.Ensures(Contract.Result<string>() != null, "Contract message: couldn't be null.");
            return string.Empty;    
        }

        private ICaseConverterContracts() { }
    }

    public class CurrentCultureUpperCaseFormatter : ICaseConverter
    {
        public string Convert(string text)
        {
            return text.ToUpper(CultureInfo.CurrentCulture);
        }
    }
}
