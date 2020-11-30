using System.Collections.Generic;

namespace Tweekenizer
{
    public interface ITokenizer
    {
        public IEnumerable<Token> Tokenize(string text);

        public string[] GetValues(string category);

        public string[] GetHashtags();

        public string[] GetMentions();

        public string[] GetUrls();

        public string[] GetEmails();
    }
}
