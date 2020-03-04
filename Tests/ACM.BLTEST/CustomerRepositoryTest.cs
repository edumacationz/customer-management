using System.Collections.Generic;
using NUnit.Framework;
using ACM.BL;


namespace ACM.BLTEST
{
  public class CustomerRepositoryTest
  {
    [Test]
    public void RetrieveValid()
    {
      var repo = new CustomerRepository();
      var expected = new Customer(1)
      {
        Email = "fbaggins@hobbiton.me",
        FirstName = "Frodo",
        LastName = "Baggins"
      };

      var actual = repo.Retrieve(1);

      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.Email, actual.Email);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);
    }

    [Test]
    public void RetrieveExistingWithAddress()
    {
      var repo = new CustomerRepository();

      var expected = new Customer(1)
      {
        Email = "fbaggins@hobbiton.me",
        FirstName = "Frodo",
        LastName = "Baggins",
        AddressList = new List<Address>()
        {
          new Address(1)
          {
            Type = AddressType.Home,
            Street1 = "Bag End",
            Street2 = "Bagshot row",
            City = "Hobbiton",
            Province = "Shire",
            Country = "Middle Earth",
            PostalCode = "144"
          },
          new Address(2)
          {
            Type = AddressType.Work,
            Street1 = "Green Dragon",
            City = "Bywater",
            Province = "Shire",
            Country = "Middle Earth",
            PostalCode = "146"
          }
        }
      };

      var actual = repo.Retrieve(1);

      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.Email, actual.Email);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);

      for (var i = 0; i < expected.AddressList.Count; i++)
      {
        var address = actual.AddressList[i];

        Assert.AreEqual(expected.AddressList[i].Type, address.Type);
        Assert.AreEqual(expected.AddressList[i].Street1, address.Street1);
        Assert.AreEqual(expected.AddressList[i].Street2, address.Street2);
        Assert.AreEqual(expected.AddressList[i].City, address.City);
        Assert.AreEqual(expected.AddressList[i].Country, address.Country);
        Assert.AreEqual(expected.AddressList[i].Province, address.Province);
        Assert.AreEqual(expected.AddressList[i].PostalCode, address.PostalCode);
      }

    }
  }
}