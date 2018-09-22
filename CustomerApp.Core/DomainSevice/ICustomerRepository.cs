using CustomerApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Core.DomainSevice
{
    public interface ICustomerRepository
    {
        // -- CustomerRepository --
        // Create Data
        // No Id when enter, but Id when exist
        Customer Create(Customer customer);

        // Read Data
        Customer Read(int id);
        List<Customer> ReadAll();

        // Update Data
        Customer Update(Customer customerUpdate);

        // Delete Data
        Customer Delete(int id);
    }
}
