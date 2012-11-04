using System.IO;
using ConcodanceApp.Common;

namespace ConcodanceApp
{
    public class InputTextServiceFileLocation : ITextInputService
    {
        #region ITextInputService Members

        public string  ReadTextFile()
        {
            
            StreamReader sReader = new StreamReader(FileLocation);
            string textFromFile = sReader.ReadToEnd();
            sReader.Close();
            return textFromFile.ToLower();

        }


        public string FileLocation { get; set; }

        #endregion
    }
}