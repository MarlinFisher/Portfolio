namespace Portfolio.Core
{
    public class Person : Element, IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}