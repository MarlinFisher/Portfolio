namespace Portfolio.Core
{
    using System.Collections.Generic;

    public interface ISkill : IElement
    {
        ISkill Parent { get; set; }
        ICollection<ILevel> Levels { get; }
    }
}