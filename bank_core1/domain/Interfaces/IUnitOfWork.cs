using bank_core1.domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Interfaces
{
    public interface IUnitOfWork
    {
       
        ICustomerRepository CustomerRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        IAccountRepository AccountRepository { get; }
        IPositionRepository PositionRepository { get; } 
        ICardRepository CardRepository { get; }
        IBranchRepository BranchRepository { get; }
        ICreditRepository CreditRepository { get; }


    }
}
