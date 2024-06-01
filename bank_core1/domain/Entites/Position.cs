using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_core1.domain.Entites
{
    public class Position : IDbEntities
    {
       public int ID {  get; set; }
       public string Position_name { get; set; }

    }
}
