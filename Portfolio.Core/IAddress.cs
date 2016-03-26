namespace Portfolio.Core
{
    public interface IAddress
    {
        string Street { get; set; }
        string Unit { get; set; }
        string City { get; set; }
        string State { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
    }
}