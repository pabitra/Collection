using System;
using System.Collections.Generic;
using System.Linq;
using ConcodanceApp.Common;
using ConcodanceApp.Model;
using ConcodanceApp;

namespace Concordance.Engine
{
    public class ConcordanceEngine : IConcordance
    {

        public ITextCleaningService CleaningService { get; set; }
        public ITextInputService InputService { get; set; }
        public ITextParsingService ParsingService { get; set; }
        public ITextCleaningService StripUnneccessaryCharacters { get; set; }
        public ITextOutPutService OutPutService { get; set; }
        public ITextCleaningService AcronymsService { get; set; }

        public ConcordanceEngine()
        {
            CleaningService= new TextCleanService();
            InputService = new InputTextServiceFileLocation();
            ParsingService = new TextParsingService();
            StripUnneccessaryCharacters = new StripSpecialCharacters();
            OutPutService = new TextConsoleOutPutService();
            AcronymsService = new ReplaceAcronymsWithWords();
        }

        public void Generate()
        {
            try
            {

                InputService.FileLocation = "Text.txt";

                string inputText = InputService.ReadTextFile();
                inputText = StripUnneccessaryCharacters.FilterSourceText(inputText);
                inputText = AcronymsService.FilterSourceText(inputText);
                List<TextStore> storesofText = ParsingService.ProcessText(inputText);
                List<FirstLevelData> firstLevelConcurranceData = new List<FirstLevelData>();

                string[] arr;
                arr = null;
                foreach (var textStore in storesofText)
                {
                    int lineIndex = textStore.LineNo;
                    arr = textStore.Sentence.Split(new char[] { ' ' });

                    IEnumerable<FirstLevelData> result = from n in arr
                                         group n by n
                                         into g
                                         orderby g.Key
                                         select new FirstLevelData { SentenceIndex = lineIndex.ToString(), Word = CleaningService.FilterSourceText(g.Key), WordCountPerSentence = g.Count() };

                    if (firstLevelConcurranceData.Count > 0)
                    {
                        foreach (FirstLevelData firstLevelData in result)
                        {
                            var res = firstLevelConcurranceData.FirstOrDefault(s => s.Word != null && s.Word == firstLevelData.Word);

                            if (res != null)
                            {
                                res.SentenceIndex = res.SentenceIndex + ", " + firstLevelData.SentenceIndex;
                                res.WordCountPerSentence = res.WordCountPerSentence + firstLevelData.WordCountPerSentence;
                            }
                            else
                            {
                                firstLevelConcurranceData.Add(firstLevelData);
                            }

                        }
                    }
                    else
                    {
                        firstLevelConcurranceData = result.ToList<FirstLevelData>();
                    }

                }
                 
                OutPutService.Print(firstLevelConcurranceData.OrderBy(s => s.Word).ToList());

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message ?? "", e.Message + e.InnerException ?? "", e.InnerException.Message);
            }
        }

    }
}