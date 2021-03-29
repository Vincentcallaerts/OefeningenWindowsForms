using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public User(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        public string VolledigeNaam()
        {
            return Name + " " + LastName;
        }
    }
}
