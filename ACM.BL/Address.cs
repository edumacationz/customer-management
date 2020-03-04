using System;

namespace ACM.BL
{
  public class Address
  {

    public int AddressId { get; private set; }
    public string Street1 { get; set; }
    public string Street2 { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public AddressType? Type { get; set; }

    public Address()
    {

    }

    public Address(int addressId)
    {
      AddressId = addressId;
    }
    public bool Validate()
    {
      var isValid = true;

      if (string.IsNullOrWhiteSpace(Street1)) isValid = false;
      if (string.IsNullOrWhiteSpace(City)) isValid = false;
      if (string.IsNullOrWhiteSpace(Province)) isValid = false;
      if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
      if (string.IsNullOrWhiteSpace(Country)) isValid = false;
      if (Type == null) isValid = false;

      return isValid;
    }

    public override string ToString()
    {
      string address = Street1;

      if (!string.IsNullOrWhiteSpace(Street2))
      {
        address += $"\n {Street2}";
      }

      return String.Join(Environment.NewLine, address, $"{City} {Province} {PostalCode} {Country}");
    }
  }

  public enum AddressType
  {
    Home,
    Work
  }

}