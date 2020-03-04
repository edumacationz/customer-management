namespace ACM.BL
{
  public class OrderItem
  {
    public int OrderItemId { get; private set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal? PurchasePrice { get; set; }
    public OrderItem()
    {

    }

    public OrderItem(int orderItemId)
    {
      OrderItemId = orderItemId;
    }

    public bool Validate()
    {
      var isValid = true;

      if (Quantity <= 0) isValid = false;
      if (ProductId <= 0) isValid = false;
      if (PurchasePrice == null) isValid = false;

      return isValid;
    }

    public bool Save()
    {
      return true;
    }

    public OrderItem Retrieve()
    {
      return new OrderItem();
    }

    public OrderItem Retrieve(int orderItemId)
    {
      return new OrderItem();
    }
  }
}