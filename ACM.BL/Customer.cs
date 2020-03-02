using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  public class Customer
  {
    public int CustomerId
    {
      get;
      private set;
    }
    public string Email { get; set; }
    private string _lastName;
    public string FirstName { get; set; }

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

    public static int InstanceCount { get; set; }

    public bool Validate() 
    {
      var isValid = true;


    if(string.IsNullOrEmpty(LastName)) isValid = false;
    if(string.IsNullOrWhiteSpace(Email)) isValid = false;

      return isValid;
    }

    public Customer Retrieve(int customerId)
    {

      return new Customer();
    }

    public List<Customer> Retrieve()
    {

      return new List<Customer>();
    }


    public bool Save()
    {

      return true;
    }
  }
}
