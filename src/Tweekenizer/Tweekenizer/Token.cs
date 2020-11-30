namespace Tweekenizer
{
    public record Token
    {
        public string Value { get; }

        public string Category { get; }

        public Token(string value, string category) => (Value, Category) = (value, category);
    }
}
