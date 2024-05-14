using bank_core1.domain.Entites;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(Employee customer);

        void Update(Employee customer); 
        void Delete(int id);
        List<Employee> GetAll();
        Employee Get(int id);

    }
}
