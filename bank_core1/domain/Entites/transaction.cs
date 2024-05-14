using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Entites
{
    public class transaction
    {
       public  int ID { get; set; }
       public  string transaction_name { get; set; }
       public  int customer_id { get; set; }
       public  double amount { get; set; }
       public  DateTime transaction_date { get; set; }
    }
}
