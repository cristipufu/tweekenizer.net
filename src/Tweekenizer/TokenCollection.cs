using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tweekenizer
{
    public class TokenCollection : IEnumerable<Token>
    {
        private readonly List<Token> _tokens;

        public TokenCollection()
        {
            _tokens = new List<Token>();
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

        public string[] GetTickers()
        {
            return GetValues(TokenCategories.TickerSymbol)
        }

        public override string ToString()
        {
            return string.Join('\n', _tokens.Select(t => t.ToString()));
        }

        internal void AddToken(Token token)
        {
            _tokens.Add(token);
        }

        public IEnumerator<Token> GetEnumerator()
        {
            return _tokens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _tokens.GetEnumerator();
        }
    }
}
