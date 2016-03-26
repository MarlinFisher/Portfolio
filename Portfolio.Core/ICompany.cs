namespace Portfolio.Core
{
    using System.Collections.Generic;

    public interface ICompany : IElement
    {
        string Phone { get; set; }
        string Email { get; set; }
        string Link { get; set; }
        IAddress Address { get; set; }
        ICollection<IPerson> People { get; }
    }
}