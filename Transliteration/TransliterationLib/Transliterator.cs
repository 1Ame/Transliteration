using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransliterationLib
{
    public static class Transliterator
    {
        public static string GetTransliteration(string sourceText, Language language)
        {
            return new Converter(language).GetTransliteration(sourceText);
        }
    }
}
