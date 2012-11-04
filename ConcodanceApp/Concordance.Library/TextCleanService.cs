using System.Text.RegularExpressions;
using ConcodanceApp.Common;

namespace ConcodanceApp
{
    public class TextCleanService : ITextCleaningService
    {
        public string FilterSourceText(string currentString)
        {
      
            string sourceStr = currentString;
            string rgPattern = @"[\\\/:\*\?\.\,""<>|]";
            Regex oRegex = new Regex(rgPattern);
            sourceStr = oRegex.Replace(sourceStr, "");
            return sourceStr;
        }

    }
}