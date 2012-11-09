using System.Collections.Generic;
using ConcodanceApp.Common;

namespace ConcodanceApp
{
    public class ReplaceAcronymsWithWords : ITextCleaningService
    {
        private readonly System.Collections.Generic.Dictionary<string, string> _dictionary;

        public ReplaceAcronymsWithWords()
        {
            _dictionary= new Dictionary<string, string>();

            _dictionary.Add("etc.", "and so forth");
            _dictionary.Add("i.e.", "this is");
            _dictionary.Add("eg.", "for example");
            _dictionary.Add("e.g.", "for example");

        }

        public string FilterSourceText(string currentString)
        {
            foreach (KeyValuePair<string, string> keyValuePair in _dictionary)
            {
                currentString = currentString.Replace(keyValuePair.Key, keyValuePair.Value);
            }

            return currentString;
        }
    }
}