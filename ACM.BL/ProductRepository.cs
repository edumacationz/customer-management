namespace ACM.BL
{
  public class ProductRepository
  {
    public Product Retrieve(int productId)
    {
      var product = new Product(productId);

      if (productId == 2)
      {
        product.Name = "Sunflowers";
        product.Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
        product.CurrentPrice = 15.96M;
      }

      return product;
    }

    public bool Save(Product product)
    {
      var success = true;

      if (product.HasChanges)
      {
        if (product.IsValid)
        {
          if (product.IsNew)
          {

          }
          else
          {

          }
        }
        else
        {
          success = false;
        }
      }

      return success;
    }
  }
}