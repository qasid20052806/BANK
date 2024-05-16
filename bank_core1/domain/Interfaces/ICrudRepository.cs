using bank_core1.domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Interfaces
{
    public interface ICrudRepository<T>
    {
        void Add(T item);

        void Update(T item);
        void Delete(int id);
        List<T> GetAll();
        T Get(int id);
    }
}
