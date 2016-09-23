using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TransliterationLib
{
    public partial class Converter
    {
        private readonly Language _language;
        private readonly Dictionary<char, string> _letterSet;
        private readonly Dictionary<string, string> _ruleSet;

        public Converter(Language language)
        {
            _language = language;
            _letterSet = letterSets[(int)language];
            _ruleSet = rulesSets[(int)language];           
        }

        public string GetTransliteration(string sourceText)
        {
            if (string.IsNullOrEmpty(sourceText))
                return sourceText;

            sourceText = ImplementRules(sourceText);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < sourceText.Length; i++)
            {
                if (i == 0 || char.IsSeparator(sourceText[i - 1]))
                {
                    result.Append(GetLetterSubstitute(sourceText[i], Position.BeginningOfWord));
                }
                else
                {
                    result.Append(GetLetterSubstitute(sourceText[i], Position.MiddleofWord));
                }
            }
            return result.ToString();
        } 

        private string GetLetterSubstitute(char source, Position position)
        {
            if (!_letterSet.ContainsKey(source))
                return source.ToString();

            //if it is first lowercase letter of a new word 
            if (char.IsLower(source) && position == Position.BeginningOfWord)
                return _letterSet[char.ToUpper(source)].ToLower();

            return _letterSet[source];
        }
        private string ImplementRules(string sourceText)
        {
            StringBuilder result = new StringBuilder(sourceText);
            foreach (var rule in _ruleSet)
            {
                result.Replace(rule.Key, rule.Value);
            }            
            return result.ToString();
        }
    }

    //letter position in the word
    public enum Position
    {
        BeginningOfWord,
        MiddleofWord
    };
}
