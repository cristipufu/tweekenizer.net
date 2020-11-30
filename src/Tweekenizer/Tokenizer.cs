using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tweekenizer
{
    public class Tokenizer : ITokenizer
    {
        private readonly List<Token> _tokens;
        private readonly List<RegexCategory> _regexCategories;

        public Tokenizer() : this(new RegexCollection())
        {
        }

        public Tokenizer(RegexCollection rgxs)
        {
            _tokens = new List<Token>();
            _regexCategories = rgxs.Get();
        }

        public IEnumerable<Token> Tokenize(string text)
        {
            _tokens.Clear();

            TokenizeRecursive(text, 0);

            return _tokens;
        }

        protected void TokenizeRecursive(string text, int categoryIndex)
        {
            if (categoryIndex == _regexCategories.Count)
            {
                return;
            }

            var sentence = text.Trim();

            var rgx = _regexCategories[categoryIndex];

            var matches = Regex.Matches(sentence, rgx.Regex);
            var fillings = Regex.Split(sentence, rgx.Regex);

            foreach (var match in matches)
            {
                _tokens.Add(new Token(match.ToString(), rgx.Category));
            }

            categoryIndex++;

            foreach (var filling in fillings)
            {
                TokenizeRecursive(filling, categoryIndex);
            }
        }

        public string[] GetValues(string category)
        {
            return _tokens.Where(x => x.Category == category).Select(x => x.Value).ToArray();
        }

        public string[] GetHashtags()
        {
            return GetValues(TokenCategories.Hashtag);
        }

        public string[] GetMentions()
        {
            return GetValues(TokenCategories.Mention);
        }

        public string[] GetUrls()
        {
            return GetValues(TokenCategories.Url);
        }

        public string[] GetEmails()
        {
            return GetValues(TokenCategories.Email);
        }

        public override string ToString()
        {
            return string.Join('\n', _tokens.Select(t => t.ToString()));
        }
    }
}
