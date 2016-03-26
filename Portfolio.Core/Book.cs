namespace Portfolio.Core
{
    public class Book : Event, IBook
    {
        public string Author { get; set; }
        public string Isdn { get; set; }
        public string Link { get; set; }
    }
}