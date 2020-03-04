using System.Collections.Generic;

namespace ACM.BL
{
  public class AddressRepository
  {
    public Address Retrieve(int addressId)
    {
      var address = new Address(addressId);

      if (addressId == 1)
      {
        address.Type = AddressType.Home;
        address.Street1 = "Bag End";
        address.Street2 = "Bagshot Row";
        address.City = "Hobbiton";
        address.Province = "Shire";
        address.Country = "Middle Earth";
        address.PostalCode = "144";

      }

      return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
      var addressList = new List<Address>();
      Address address = new Address(1)
      {
        Type = AddressType.Home,
        Street1 = "Bag End",
        Street2 = "Bagshot row",
        City = "Hobbiton",
        Province = "Shire",
        Country = "Middle Earth",
        PostalCode = "144"
      };
      addressList.Add(address);

      address = new Address(2)
      {
        Type = AddressType.Work,
        Street1 = "Green Dragon",
        City = "Bywater",
        Province = "Shire",
        Country = "Middle Earth",
        PostalCode = "146"
      };
      addressList.Add(address);

      return addressList;
    }
  }
}