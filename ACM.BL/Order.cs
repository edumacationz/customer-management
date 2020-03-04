using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
  public class Order : EntityBase, ILoggable
  {
    public DateTimeOffset? OrderDate { get; set; }
    public int OrderId { get; private set; }

    public int CustomerId { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public int ShippingAddressId { get; set; }

    public Order() : this(0)
    {

    }
    public Order(int orderId)
    {
      OrderId = orderId;
      OrderItems = new List<OrderItem>();
    }
    public override bool Validate()
    {
      var isValid = true;

      if (OrderDate == null) isValid = false;

      return isValid;
    }

    public override string ToString() => $"{OrderDate.Value.ToString()} ({OrderId})";


    public string Log() =>
   $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState.ToString()}";
  }
}