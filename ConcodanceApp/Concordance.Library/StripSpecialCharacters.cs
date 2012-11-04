using ConcodanceApp.Common;

namespace ConcodanceApp
{
    public class StripSpecialCharacters : ITextCleaningService
    {
        public string FilterSourceText(string currentString)
        {

            string a = currentString;
            a = a.Replace("\"", "");
            a = a.Replace("---", "");
            a = a.Replace("--", "");
            a = a.Replace("pe0", "");
            a = a.Replace("a0", "");
            a = a.Replace("â", "");
            a = a.Replace("0", "");
            a = a.Replace("1", "");
            a = a.Replace("2", "");
            a = a.Replace("3", "");
            a = a.Replace("4", "");
            a = a.Replace("5", "");
            a = a.Replace("6", "");
            a = a.Replace("7", "");
            a = a.Replace("8", "");
            a = a.Replace("9", "");
            a = a.Replace("{", "");
            a = a.Replace("}", "");
            a = a.Replace("[", "");
            a = a.Replace("]", "");
            a = a.Replace("``", "");
            a = a.Replace("''", "");
            a = a.Replace("(", "");
            return a;
        
        }
    }
}