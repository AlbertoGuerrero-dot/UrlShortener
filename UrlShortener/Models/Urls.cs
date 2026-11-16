namespace UrlShortener.Models
{
    public class Urls
    {
        public int Id { get; set; }
        public required string OriginalUrl { get; set; }
        public required string ShortendUrl { get; set; }
        public string Alias { get; set; } = string.Empty;
    }
}
