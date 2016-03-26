namespace Portfolio.Core
{
    using System;

    public interface IEvent : IElement
    {
        DateTimeOffset StartDate { get; set; }
        DateTimeOffset EndDate { get; set; }
    }
}