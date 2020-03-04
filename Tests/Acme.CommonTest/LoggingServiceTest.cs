using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using NUnit.Framework;


namespace Acme.CommonTest
{
  public class LoggingServiceTest
  {
    [Test]
    public void WriteToFileTest()
    {
      // Arrange
      var changedItems = new List<ILoggable>();

      var customer = new Customer(1)
      {
        Email = "fbaggins@hobbiton.me",
        FirstName = "Frodo",
        LastName = "Baggins",
        AddressList = null
      };
      changedItems.Add(customer);

      var product = new Product(2)
      {
        Name = "Rake",
        Description = "Garden Rake with Steel Head",
        CurrentPrice = 6M
      };
      changedItems.Add(product);

      // Act
      LoggingService.WriteToFile(changedItems);

      // Assert
      // Nothing here to assert
    }
  }
}
