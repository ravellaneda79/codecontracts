using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace PoC_Contracts
{
    public class PoC_Abbreviators
    {
        public string Filename { get; set; }
        public List<string> Metadata = new List<string>();

        [ContractAbbreviator]
        private void ValidateNameAndMetadata(string filename, List<string> metadata, int maxlength)
        {
            Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(filename), "The filename cannot be blank");
            Contract.Requires(metadata != null);
            Contract.Requires(metadata.Count < maxlength);
        }

        public void Change(string filename, List<string> metadata)
        {
            ValidateNameAndMetadata(filename, metadata, 5);
            Filename = null;
            Metadata.Clear();
            Filename = filename;
            Metadata.AddRange(metadata);
        }
    }
}
