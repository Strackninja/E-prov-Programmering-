using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Human : Superhero
    {
        public Human()
        {
            hp = 100;
            dmg = 15;
            Spdmg = 15;
            name = "Human";
            Getstats();
        }


    }
}
