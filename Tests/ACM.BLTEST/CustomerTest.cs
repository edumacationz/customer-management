using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTEST
{
  public class CustomerTest
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FullNameTestValid()
    {
      Customer customer = new Customer()
      {
        FirstName = "Bilbo",
        LastName = "Baggins"
      };

      string expected = "Baggins, Bilbo";

      string actual = customer.FullName;

      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void FullNameLastNameEmpty()
    {
      Customer customer = new Customer
      {
        FirstName = "Bilbo"
      };

      string expected = "Bilbo";

      string actual = customer.FullName;

      Assert.AreEqual(expected, actual);

    }

    [Test]
    public void FullNameFirstNameEmpty()
    {
      Customer customer = new Customer
      {
        FirstName = "Baggins"
      };

      string expected = "Baggins";

      string actual = customer.FullName;

      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void StaticTest()
    {
      var c1 = new Customer();
      c1.FirstName = "Bilbo";
      Customer.InstanceCount += 1;

      var c2 = new Customer();
      c2.FirstName = "Frodo";
      Customer.InstanceCount += 1;

      var c3 = new Customer();
      c3.FirstName = "Rosie";
      Customer.InstanceCount += 1;

      Assert.AreEqual(3, Customer.InstanceCount);
    }
  }
}