using bank_core1.domain.Entites;
using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Interfaces
{
    public interface ICustomerRepository : ICrudRepository<Customer>
    {
       

    }
}
