using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Superhero
    {
        // Gemensamma Värden varenda Superhero har
        public int hp;
        public int dmg;
        public int Spdmg;
        public string name;

        // En metod som printar ut Superherons stats
        public void Getstats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("DMG: " + dmg);
            Console.WriteLine("SP.DMG: " +Spdmg);

        }

    }
}
