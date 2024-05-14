using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK.domain.Entites
{
    public class Customer
    {
        int ID { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        DateTime birthDate { get; set; }
        DateTime joinTime { get; set; }
        string address { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
    }
}
