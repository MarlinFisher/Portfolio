namespace Portfolio.Core
{
    using System.Collections.Generic;

    public interface IProject : IEvent
    {
        string Responsibilities { get; set; }
        string Link { get; set; }
        ICollection<ISkill> Skills { get; }
        
    }
}