using System.Collections.Generic;

namespace ConcodanceApp.Common
{

    using ConcodanceApp.Model;

    public interface ITextParsingService
    {
        List<TextStore> ProcessText(string text);
    }
}