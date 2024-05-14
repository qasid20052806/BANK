using bank_core1.domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Interfaces
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        void Update(Employee employee);
        void Delete(int id);
        List<Employee> GetAll();
        Employee Get(int id);
    }
}
