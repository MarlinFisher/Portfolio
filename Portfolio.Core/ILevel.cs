namespace Portfolio.Core
{
    using System;

    public interface ILevel
    {
        double Value { get; set; }
        DateTimeOffset Date { get; set; }
    }
}