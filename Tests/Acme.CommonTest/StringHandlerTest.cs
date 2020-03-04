using NUnit.Framework;
using Acme.Common;

namespace Acme.CommonTest
{
  public class StringHandlerTest
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void InsertSpacesTestValid()
    {
      var source = "SonicScrewdriver";
      var expected = "Sonic Screwdriver";

      var actual = StringHandler.InsertSpaces(source);

      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void InsertSpacesTestWithExistingSpace()
    {
      var source = "Sonic Screwdriver";
      var expected = "Sonic Screwdriver";

      var actual = StringHandler.InsertSpaces(source);

      Assert.AreEqual(expected, actual);
    }
  }
}