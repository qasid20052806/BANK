using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Entites
{
    public class card : IDbEntities
    {
       public int Id { get; set; }
       public int Account_id { get; set; }
       public string card_number { get; set; }
       public string expiry_date { get; set; }
       public string CVV { get; set; }
    }
}
