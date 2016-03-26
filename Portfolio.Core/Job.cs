namespace Portfolio.Core
{
    using System.Collections.Generic;

    public class Job : Event, IJob
    {
        public string ReasonForLeaving { get; set; }
        public decimal StartSalary { get; set; }
        public decimal EndSalary { get; set; }
        public ICompany Company { get; set; }
        public ICollection<IProject> Projects { get; }
    }
}