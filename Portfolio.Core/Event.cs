namespace Portfolio.Core
{
    using System;

    public abstract class Event : Element, IEvent
    {
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}