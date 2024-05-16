using bank_core1.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.DataAccess.SQLserver
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        ICustomerRepository IUnitOfWork.CustomerRepository => new SqlCustomerRepository();

        IEmployeeRepository IUnitOfWork.EmployeeRepository => new SqlEmployeeRepository(
    }
}
