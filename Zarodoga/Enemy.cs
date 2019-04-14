using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodoga
{
    class Ellenseg
    {
        private string name;
        private int healt_Point;
        private int level;

        // Ellenségek neve
        string[] ellenseg = new string[5] { "ooze", "ancient", "forestspirit", "lizard", "shroom"};

        
        // Random number 
        Random Rand = new Random();

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Healt_Point
        {
            get
            {
                return healt_Point;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
        }

        //Random enemy
        public Ellenseg()
        {
            this.name = ellenseg[Rand.Next(0,5)];
            this.level = Rand.Next(1,6);
            this.healt_Point = level * 20 + 50;
        }
    }
}
