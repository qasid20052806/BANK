using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Entites
{
    public class Account
    {
       public int ID { get; set; }
       public int Customer_id { get; set; }
       public double Balance { get; set; }
       public string Account_type { get; set; }
       public DateTime Openning_date { get; set; }

    }
}
