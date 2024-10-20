namespace LandonWalkerA6.Model
{
    public class JSONModel(string title, string author, int pageLength, string genre, int year, double msrp)
    {
        public string? Title { get; set; } = title;
        public string? Author { get; set; } = author;
        public int PageLength { get; set; } = pageLength;
        public string? Genre { get; set; } = genre;
        public int YearPublished { get; set; } = year;
        public double Msrp { get; set; } = msrp;
    }
}
