namespace Portfolio.Core
{
    using System.Collections.Generic;

    public class Project : Event, IProject
    {
        public string Responsibilities { get; set; }
        public string Link { get; set; }
        public ICollection<ISkill> Skills { get; }
    }
}