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
            if (firstLevelConcurranceData[0].Word.Length==0)
                firstLevelConcurranceData.RemoveAt(0);

            foreach (var source in firstLevelConcurranceData)
            {
               
                Console.WriteLine(source.Word + "\t\t\t\t{" + source.WordCountPerSentence.ToString() + ":" +
                                  source.SentenceIndex + "}");
            }

            Console.Read();
        }
    }
}