using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodoga
{
    class Player
    {
        public string username;
        public int id;
        public int arany;
        public int tapasztalat;
        public int jogosultsag;
        public List<Player> Aktualis = new List<Player>();

        public Player(string username, int id, int arany, int tapasztalat, int jogosultsag)
        {
            this.username = username;
            this.id = id;
            this.arany = arany;
            this.tapasztalat = tapasztalat;
            this.jogosultsag = jogosultsag;
        }

        public void Aktualis_Player(Player p)
        {
            Aktualis.Add(p);
        }

    }
}
