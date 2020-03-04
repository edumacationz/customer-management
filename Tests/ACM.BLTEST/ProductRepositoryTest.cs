using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTEST
{
  public class ProductRepositoryTest
  {

    [Test]
    public void RetrieveTest()
    {
      var repo = new ProductRepository();
      var expected = new Product(2)
      {
        CurrentPrice = 15.96M,
        Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
        Name = "Sunflowers"
      };

      var actual = repo.Retrieve(2);

      Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
      Assert.AreEqual(expected.Description, actual.Description);
      Assert.AreEqual(expected.Name, actual.Name);
    }

    [Test]
    public void SaveTestValid()
    {
      var repo = new ProductRepository();
      var updatedProduct = new Product(2)
      {
        CurrentPrice = 18M,
        Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
        Name = "Sunflowers",
        HasChanges = true
      };

      var actual = repo.Save(updatedProduct);

      Assert.AreEqual(true, actual);
    }

    [Test]
    public void SaveTestMissingPrice()
    {
      var repo = new ProductRepository();
      var updatedProduct = new Product(2)
      {
        CurrentPrice = null,
        Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
        Name = "Sunflowers",
        HasChanges = true
      };

      var actual = repo.Save(updatedProduct);

      Assert.AreEqual(false, actual);
    }
  }
}