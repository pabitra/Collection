using System.Text.RegularExpressions;
using ConcodanceApp.Common;

namespace ConcodanceApp
{
    public class StripSpecialCharacters : ITextCleaningService
    {
        public string FilterSourceText(string currentString)
        {

            string a = currentString;
            a = ConvertWhitespaceToSpacesString(a);
            a = ConvertWhitespaceToSpacesStringV1(a);
            a = ConvertWhitespacesToSingleSpaces(a);
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
            a = a.Replace(")", "");
            a = a.Replace(",", "");
            a = a.Replace(":", "");
            return a.Trim();
        
        }
        private string ConvertWhitespaceToSpacesString(string value)
        {
            value = value.Replace('\r', ' ');
            value = value.Replace('\n', ' ');
            return value;
        }

        private string ConvertWhitespaceToSpacesStringV1(string value)
        {
            value = value.Replace('\r', ' ');
            value = value.Replace('\n', ' ');
            return value;
        }
        private string ConvertWhitespacesToSingleSpaces(string value)
        {
            value = Regex.Replace(value, @"\s+", " ");
            return value;
        }
    }
}