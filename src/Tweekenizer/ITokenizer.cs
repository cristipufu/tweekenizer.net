namespace Tweekenizer
{
    public interface ITokenizer
    {
        TokenCollection Tokenize(string text);
    }
}