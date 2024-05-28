using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bank_core1.domain.Entites
{
    public class Employee : IDbEntities
    {
        public int Id { get; set; }
       
        public string name { get; set; }
        public string surname { get; set; }
       
        public int positionId { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime startWork {  get; set; }

    }
}
