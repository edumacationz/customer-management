using System;
using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTEST
{
  public class OrderRepositoryTest
  {
    [Test]
    public void RetrieveTest()
    {
      var repo = new OrderRepository();

      var expected = new Order(10)
      {
        OrderDate = new DateTimeOffset(
          DateTime.Now.Year, 4, 14, 10, 00, 00,
          new TimeSpan(7, 0, 0))
      };

      var actual = repo.Retrieve(10);

      Assert.AreEqual(expected.OrderDate, actual.OrderDate);
    }
  }
}