namespace Tweekenizer
{
    public record RegexCategory
    {
        public string Category { get; set; }

        public string Regex { get; set; }

        public RegexCategory(string category, string regex) => (Category, Regex) = (category, regex);
    }
}
