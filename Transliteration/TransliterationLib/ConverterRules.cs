using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransliterationLib
{
    public partial class Converter
    {
        //if we will need some other languages we can add them
        private static readonly Dictionary<char, string>[] letterSets =
        {
            new Dictionary<char, string>
            {
                //uppercase letters 
                //use it for transliteration of letters 
                //whitch are the first letters of words
                { 'А', "A" },
                {'Б', "B" },
                {'В', "V" },
                {'Г', "H" },
                {'Ґ', "G" },
                {'Д', "D" },
                {'Е', "E" },
                {'Є', "Ye" },
                {'Ж', "Zh" },
                {'З', "Z" },
                {'И', "Y" },
                {'І', "I" },
                {'Ї', "Yi" },
                {'Й', "Y" },
                {'К', "K" },
                {'Л', "L" },
                {'М', "M" },
                {'Н', "N" },
                {'О', "O" },
                {'П', "P" },
                {'Р', "R" },
                {'С', "S" },
                {'Т', "T" },
                {'У', "U" },
                {'Ф', "F" },
                {'Х', "Kh" },
                {'Ц', "Ts" },
                {'Ч', "Ch" },
                {'Ш', "Sh" },
                {'Щ', "Shch" },
                {'Ю', "Yu" },
                {'Я', "Ya" },
            
                //lowercase letters
                //use for transliteration of letters 
                //witch care in the middle of words
                {'а', "a" },
                {'б', "b" },
                {'в', "v"},
                {'г', "h"},
                {'ґ', "g"},
                {'д', "d"},
                {'е', "e" },
                {'є', "ie" },
                {'ж', "zh" },
                {'з', "z"},
                {'и', "y"},
                {'і', "i"},
                {'ї', "i"},
                {'й', "i"},
                {'к', "k"},
                {'л', "l"},
                {'м', "m"},
                {'н', "n"},
                {'о', "o"},
                {'п', "p"},
                {'р', "r"},
                {'с', "s"},
                {'т', "t"},
                {'у', "u"},
                {'ф', "f" },
                {'х', "kh"},
                {'ц', "ts"},
                {'ч', "ch"},
                {'ш', "sh" },
                {'щ', "shch"},
                {'ю', "iu" },
                {'я', "ia" }
            }
        };

        private static readonly Dictionary<string, string>[] rulesSets =
        {
            new Dictionary<string, string>
            {
                ////special rules
                {"зг", "zgh" },
                {"Зг", "Zgh"},
                {"\'", ""},
                {"ь", ""},
            }
        };
    }
}
