namespace Portfolio.Core
{
    public interface IPerson : IElement
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Title { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}