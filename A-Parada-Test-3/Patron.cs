using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Parada_Test_3
{
    class Patron
    {
        public string Name { get; set; }
        public string PatronID { get; set; }
      
        public Patron(string name, string id)
        {
            Name = name;
            PatronID = id;
        }   

        public string GetPatron()
        {
            return $"{Name}, {PatronID}";
        }
    }
}
