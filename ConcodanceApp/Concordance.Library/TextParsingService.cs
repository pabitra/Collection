using System;
using System.Collections.Generic;
using ConcodanceApp.Common;
using ConcodanceApp.Model;

namespace ConcodanceApp
{
    public class TextParsingService : ITextParsingService
    {
        #region ITextParsingService Members

        public List<TextStore> ProcessText(string text)
        {
            string[] inputTextArray = text.ToLower().Split(new char[] {'.', '?', '!', ';'},
                                                           StringSplitOptions.RemoveEmptyEntries);

            List<TextStore> textStores= new List<TextStore>();

            for(int sentenceindex=0; sentenceindex < inputTextArray.Length; sentenceindex++)
            {
                var txts = new TextStore { LineNo = sentenceindex + 1, Sentence = inputTextArray[sentenceindex] };
                textStores.Add(txts);
            }

            return textStores;

        }

        #endregion
    }
}