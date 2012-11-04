using System.Text;
using ConcodanceApp.Common;
using Concordance.Engine;

namespace ConcodanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConcordance conCordaceEngine = new ConcordanceEngine();

            conCordaceEngine.Generate();

        }

    }
}
