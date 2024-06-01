using bank_core1.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Entites
{
    public interface IAccountRepository : ICrudRepository<Account>
    {

    }
}
