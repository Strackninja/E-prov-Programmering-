using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Alien : Superhero
    {
        public Alien()
        {
            hp = 80;
            dmg = 5;
            Spdmg = 25;
            name = "Alien";
            Getstats();
        }
    }
}
