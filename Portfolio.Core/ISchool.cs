namespace Portfolio.Core
{
    using System.Collections.Generic;

    public interface ISchool : IEvent
    {
        IAddress Address { get; set; }
        ICollection<IPerson> People { get; }
        ICollection<IProject> Projects { get; }
    }
}