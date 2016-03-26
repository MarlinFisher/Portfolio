namespace Portfolio.Core
{
    public interface IElement
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
        string Image { get; set; }
    }
}