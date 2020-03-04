using Acme.Common;

namespace ACM.BL
{
  public class Product : EntityBase, ILoggable
  {
    public int ProductId { get; private set; }
    public string Description { get; set; }
    public decimal? CurrentPrice { get; set; }

    private string _name;
    public string Name
    {
      get
      {
        return _name.InsertSpaces();
      }
      set
      {
        _name = value;
      }
    }

    public Product()
    {

    }

    public Product(int productId)
    {
      ProductId = productId;
    }

    public string Log() =>
$"{ProductId}: {Name} Description: {Description} Status: {EntityState.ToString()}";



    public override bool Validate()
    {
      var isValid = true;

      if (string.IsNullOrWhiteSpace(Name)) isValid = false;
      if (CurrentPrice == null) isValid = false;

      return isValid;
    }

    public override string ToString() => Name;
  }
}