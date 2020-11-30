using System.Collections.Generic;

namespace Tweekenizer
{
    public interface ITokenizer
    {
        IEnumerable<Token> Tokenize(string text);

        string[] GetValues(string category);

        string[] GetHashtags();

        string[] GetMentions();

        string[] GetUrls();

        string[] GetEmails();
    }
}
