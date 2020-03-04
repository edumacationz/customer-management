using System.Linq;

namespace ACM.BL
{
  public class CustomerRepository
  {

    private AddressRepository addressRepository { get; set; }


    public CustomerRepository()
    {
      addressRepository = new AddressRepository();
    }
    public Customer Retrieve(int customerId)
    {
      var customer = new Customer(customerId);

      if (customer.CustomerId == 1)
      {
        customer.Email = "fbaggins@hobbiton.me";
        customer.FirstName = "Frodo";
        customer.LastName = "Baggins";
        customer.AddressList = addressRepository.RetrieveByCustomerId(customer.CustomerId).ToList();
      }

      return customer;
    }

    public bool Save(Customer customer)
    {
      return true;
    }
  }
}