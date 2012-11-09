using System;
using System.Collections.Generic;
using System.Linq;
using ConcodanceApp.Common;
using ConcodanceApp.Model;

namespace ConcodanceApp
{
    public class TextConsoleOutPutService : ITextOutPutService
    {
        public void Print(List<FirstLevelData> firstLevelConcurranceData)
        {
            

            foreach (var source in firstLevelConcurranceData)
            {
               
                Console.WriteLine(source.Word + "\t\t\t\t{" + source.WordCountPerSentence.ToString() + ":" +
                                  source.SentenceIndex + "}");
            }

            Console.Read();
        }
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}