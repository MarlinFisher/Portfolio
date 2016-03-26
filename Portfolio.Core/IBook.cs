namespace Portfolio.Core
{
    public interface IBook : IEvent
    {
        string Author { get; set; }
        string Isdn { get; set; }
        string Link { get; set; }
    }
}