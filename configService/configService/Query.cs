namespace configService
{
    public class Query
    {
        public DateOnly Date { get; set; }

        public string? MajorVersion { get; set; }

        public string? MinorVersion { set; get; } 

        public List<string>? LstSummary { get; set; }
        public List<string>? LstDetail { get; set; }
        public List<string>? LstMore { get; set; }
    }
}