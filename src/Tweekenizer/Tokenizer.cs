using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tweekenizer
{
    public class Tokenizer : ITokenizer
    {
        private readonly List<RegexCategory> _regexCategories;

        public Tokenizer() : this(new RegexCollection())
        {
        }

        public Tokenizer(RegexCollection rgxs)
        {
            _regexCategories = rgxs.Get();
        }

        public TokenCollection Tokenize(string text)
        {
            var bucket = new TokenCollection();

            TokenizeRecursive(text, 0, bucket);

            return bucket;
        }

        protected void TokenizeRecursive(string text, int categoryIndex, TokenCollection bucket)
        {
            if (categoryIndex == _regexCategories.Count)
            {
                return;
            }

            var sentence = text.Trim();

            var rgx = _regexCategories[categoryIndex];

            categoryIndex++;
            
            var matches = Regex.Matches(sentence, rgx.Regex, RegexOptions.IgnoreCase);
            var fillings = Regex.Split(sentence, rgx.Regex, RegexOptions.IgnoreCase);

            foreach (var match in matches)
            {
                bucket.AddToken(new Token(match.ToString(), rgx.Category));
            }

            foreach (var filling in fillings)
            {
                TokenizeRecursive(filling, categoryIndex, bucket);
            }
        }
    }
}
