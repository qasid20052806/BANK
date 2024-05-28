using bank_core1.domain.Interfaces;
using Braintree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.DataAccess.SQLserver
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        public ICustomerRepository CustomerRepository => new SqlCustomerRepository();

        public IEmployeeRepository EmployeeRepository => new SqlEmployeeRepository();   
    }
}
