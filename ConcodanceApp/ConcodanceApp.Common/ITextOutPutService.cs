using System.Collections.Generic;
using ConcodanceApp.Model;

namespace ConcodanceApp.Common
{
    public interface ITextOutPutService
    {
        void Print(List<FirstLevelData> firstLevelConcurranceData);
    }
}