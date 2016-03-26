namespace Portfolio.Core
{
    using System;

    public class Level : ILevel
    {
        public double Value { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}