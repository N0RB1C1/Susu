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
            this.FormClosing += Form_Closing;
        }

        //Alkalamzás bezárása x-el
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Alkalmazás bezárása gombra
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Játék
        private void Start_Button_Click(object sender, EventArgs e)
        {
            Login form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Login")
                {
                    form = (Login)item;
                }
            }
            Adatbazis.Update_Arany(Adatbazis.Select_Player_Id(form.User_box.Text),(-10));
            InGame formGame = new InGame();
            this.Hide();
            formGame.ShowDialog();
            
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
                Adatbazis.Select_Player_Jogosultsag(id)
                );
            if (p.jogosultsag > 0)
            {
                vip_btn.Enabled = false;
            }
            Player_infolbl.Text += " " + p.username;
            Aranylbl.Text += " " + p.arany;
            Tapasztalati_szintlbl.Text += " " + Aktualisszint();
            Szintmaximum();
            if(p.arany == 0 || p.arany < 0)
            {
                Arany_button.Enabled = true;
                Arany_button.Visible = true;
                Start_Button.Enabled = false;
            }

        }

        // Progressbar maximum beállítása
        private void Szintmaximum()
        {
            if (p.tapasztalat < 100)
            {
                Szintbr.Maximum = szintek[0];
                Szintbr.Value = p.tapasztalat;
            }
            else if(p.tapasztalat >= 100 && p.tapasztalat < 300)
            {
                Szintbr.Maximum = szintek[1];
                Szintbr.Value = (p.tapasztalat - 100);
            }
            else if ((p.tapasztalat) >= 300 && p.tapasztalat < 800)
            {
                Szintbr.Maximum = szintek[2];
                Szintbr.Value = (p.tapasztalat - 300);
            }
            else if ((p.tapasztalat) >= 800 && p.tapasztalat < 1800)
            {
                Szintbr.Maximum = szintek[3];
                Szintbr.Value = (p.tapasztalat - 800);
            }
            else if (p.tapasztalat >= 1800)
            {
                Szintbr.Maximum = szintek[4];
                Szintbr.Value = (p.tapasztalat - 1800);
            }
            else
            {
                Szintbr.Maximum = p.tapasztalat;
                Szintbr.Value = p.tapasztalat;
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

        // +100 arany feltöltése
        private void Arany_button_Click(object sender, EventArgs e)
        {
            Login form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Login")
                {
                    form = (Login)item;
                }
            }
            Adatbazis.Update_Arany(Adatbazis.Select_Player_Id(form.User_box.Text), 100);
        }

        // Options ablak megnyitása
        private void Options_Button_Click(object sender, EventArgs e)
        {
            Options form = new Options();
            this.Hide();
            form.ShowDialog();
        }

        // Vip gomb megnyomása
        private void Vip_btn_Click(object sender, EventArgs e)
        {
            Login form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Login")
                {
                    form = (Login)item;
                }
            }
            Adatbazis.Update_Jogosultsag(Adatbazis.Select_Player_Id(form.User_box.Text));
            MessageBox.Show("Köszönjük, hogy támogat minket!");
            vip_btn.Enabled = false;
        }
    }
}
