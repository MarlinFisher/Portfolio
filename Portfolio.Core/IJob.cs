namespace Portfolio.Core
{
    using System.Collections.Generic;

    public interface IJob : IEvent
    {
        string ReasonForLeaving { get; set; }
        decimal StartSalary { get; set; }
        decimal EndSalary { get; set; }
        ICompany Company { get; set; }
        ICollection<IProject> Projects { get; }
    }
}