using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Android : Superhero
    {
        public Android()
        {
            hp = 120;
            dmg = 20;
            Spdmg = 10;
            name = "Android";
            Getstats();
        }


    }
}
