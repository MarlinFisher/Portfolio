namespace Portfolio.Core
{
    using System.Collections.Generic;

    public class School : Event, ISchool
    {
        public IAddress Address { get; set; }
        public ICollection<IPerson> People { get; }
        public ICollection<IProject> Projects { get; }
    }
}