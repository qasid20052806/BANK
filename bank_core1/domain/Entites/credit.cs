using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Entites
{
    public class Credit : IDbEntities

    {
        public int ID {  get; set; }   
        public int customer_id { get; set; }
        public double amount { get; set; }
        public DateTime credit_date { get; set; }

    }
}
