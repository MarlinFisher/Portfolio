namespace Portfolio.Core
{
    using System.Collections.Generic;

    public class Skill : Element, ISkill
    {
        public ISkill Parent { get; set; }
        public ICollection<ILevel> Levels { get; }
    }
}