namespace Portfolio.Core
{
    using System.Collections.Generic;

    public class Company : Element, ICompany
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Link { get; set; }
        public IAddress Address { get; set; }
        public ICollection<IPerson> People { get; }
    }
}