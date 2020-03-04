using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
  public class Customer : EntityBase, ILoggable
  {


    public int Type { get; set; }
    public int CustomerId
    {
      get;
      private set;
    }
    public string Email { get; set; }
    private string _lastName;
    public string FirstName { get; set; }

    public override string ToString() => FullName;

    public string LastName
    {
      get
      {
        return _lastName;
      }
      set
      {
        _lastName = value;
      }
    }
    public string FullName
    {
      get
      {
        string fullName = LastName;

        if (!string.IsNullOrWhiteSpace(FirstName))
        {
          if (!string.IsNullOrWhiteSpace(fullName))
          {
            fullName += ", ";
          }

          fullName += FirstName;
        }

        return fullName;
      }
    }

    public string Log() =>
    $"{CustomerId}: {FullName} Email: {Email} Status: {EntityState.ToString()}";

    public static int InstanceCount { get; set; }

    public List<Address> AddressList { get; set; }

    public Customer() : this(0)
    {

    }

    public Customer(int customerId)
    {
      CustomerId = customerId;
      AddressList = new List<Address>();
    }

    public override bool Validate()
    {
      var isValid = true;


      if (string.IsNullOrEmpty(LastName)) isValid = false;
      if (string.IsNullOrWhiteSpace(Email)) isValid = false;

      return isValid;
    }
  }
}
