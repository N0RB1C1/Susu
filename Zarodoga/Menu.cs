using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarodoga
{
    public partial class Basic : Form
    {
        Player p;
        public List<int> tapasztalat = new List<int>();
        public int arany;
        public string felhaszn;
        static private int[] szintek = new int[5] {100,200,500,1000,5000}; 

        public Basic()
        {
            InitializeComponent();
            this.FormClosing += Exit_Button_Click;
        }

        // Alkalmazás bezárása 
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Játék
        private void Start_Button_Click(object sender, EventArgs e)
        {
            InGame form = new InGame();
            this.Hide();
            form.ShowDialog();
            
        }

        // On_loadra minden
        private void Basic_Load(object sender, EventArgs e)
        {
            Login form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Login")
                {
                    form = (Login)item;
                }
            }
            int id = Adatbazis.Select_Player_Id(form.User_box.Text);
            p = new Player(form.User_box.Text,
                Adatbazis.Select_Player_Id(form.User_box.Text),
                Adatbazis.Select_Player_Arany(id),
                Adatbazis.Select_Player_Tapasztalati_Pont(id),
                Adatbazis.Select_Player_Jogosultsag(id),
                Adatbazis.Select_Player_Palya(id)
                );
            Player_infolbl.Text += " " + p.username;
            Aranylbl.Text += " " + p.arany;
            Tapasztalati_szintlbl.Text += " " + Aktualisszint();
            Szintmaximum();

        }

        // Progressbar maximum beállítása
        private void Szintmaximum()
        {
            if (p.tapasztalat >= szintek[0] && p.tapasztalat <= szintek[1])
            {
                Szintbr.Maximum = szintek[1];
                Szintbr.Value = (p.tapasztalat - szintek[0]);
            }
            else if((p.tapasztalat) >= szintek[1] && p.tapasztalat <= szintek[2])
            {
                Szintbr.Maximum = szintek[2];
                Szintbr.Value = (p.tapasztalat - (szintek[0] + szintek[1]));
            }
            else if ((p.tapasztalat) >= szintek[2] && p.tapasztalat <= szintek[3])
            {
                Szintbr.Maximum = szintek[3];
                Szintbr.Value = (p.tapasztalat - (szintek[0] + szintek[1]+ szintek[2]));
            }
            else if ((p.tapasztalat) >= szintek[3] && p.tapasztalat <= szintek[4])
            {
                Szintbr.Maximum = szintek[4];
                Szintbr.Value = (p.tapasztalat - (szintek[0] + szintek[1]+ szintek[2] + szintek[3]));
            }
            else if ((p.tapasztalat) >= szintek[4])
            {
                Szintbr.Maximum = p.tapasztalat;
                Szintbr.Value = p.tapasztalat;
            }
            else
            {
                Szintbr.Maximum = p.tapasztalat;
            }
        }

        // Aktuális szint megadása
        private int Aktualisszint()
        {
            if (p.tapasztalat < 100)
            {
                return 0;
            }
            else if (p.tapasztalat >= 100 && p.tapasztalat < 300)
            {
                return 1;
            }
            else if (p.tapasztalat >= 300 && p.tapasztalat < 800)
            {
                return 2;
            }
            else if (p.tapasztalat >= 800 && p.tapasztalat < 1800)
            {
                return 3;
            }
            else if (p.tapasztalat >= 1800 && p.tapasztalat < 6800)
            {
                return 4;
            }
            else if (p.tapasztalat >= 6800)
            {
                return 5;
            }
            return 0;
        }
    }
}
