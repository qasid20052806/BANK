using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace bank_core1.domain.Entites
{
    public class Employee
    {
        int ID { get; set; }
        string name { get; set; }
        string surname { get; set; }

        int positionId { get; set; }
        string email { get; set; }
        string phone { get; set; }
        string address { get; set; }
        DateTime birthDate { get; set; }
        DateTime startWork {  get; set; }

    }
}
