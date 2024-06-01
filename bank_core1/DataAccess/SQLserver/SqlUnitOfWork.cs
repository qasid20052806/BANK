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
        protected readonly string _connectionString = @" Data Source=QASID\MSSQLSERVER02;
                                            Initial Catalog=BANK;
                                             Integrated Security=true";
        public ICustomerRepository CustomerRepository => new SqlCustomerRepository();

        public IEmployeeRepository EmployeeRepository => new SqlEmployeeRepository();   
    }
}
