using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        public int Id { get; set; } 
          //bir müşterinin bilgilerini tutmak için kullanılır.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
