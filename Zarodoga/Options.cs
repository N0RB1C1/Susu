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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            Login form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Login")
                {
                    form = (Login)item;
                }
            }
            Felhasznalo_lbl.Text += form.User_box.Text;
        }

        private void Felhasznalo_btn_Click(object sender, EventArgs e)
        {
            if (!(Felhasznalo_box.Text.Equals(null)))
            {
                if(Adatbazis.RegisterCheck(Felhasznalo_box.Text) == 0)
                {
                    Login form = null;
                    foreach (var item in Application.OpenForms)
                    {
                        if (item.GetType().ToString() == "Zarodoga.Login")
                        {
                            form = (Login)item;
                        }
                    }
                    Adatbazis.Update_Felhasznalo(Felhasznalo_box.Text, Adatbazis.Select_Player_Id(form.User_box.Text));
                    form.User_box.Text = Felhasznalo_box.Text;                   
                    Felhasznalo_lbl.Text = "Felhasználó neve: " + Felhasznalo_box.Text;
                    Felhasznalo_box.Clear();
                    MessageBox.Show("Sikeres felhasznaló változtatás");
                }
                else
                {
                    MessageBox.Show("Van ilyen felhasznalónév!");
                }
            }
            else
            {
                MessageBox.Show("Nem töltötte ki a felhasznaló név mezőt!");
            }
        }

        private void Jelszo_btn_Click(object sender, EventArgs e)
        {
            if (Elsojelszo_box.Text.Equals(Masodikjelszo_box.Text))
            {
                Login form = null;
                foreach (var item in Application.OpenForms)
                {
                    if (item.GetType().ToString() == "Zarodoga.Login")
                    {
                        form = (Login)item;
                    }
                }
                Adatbazis.Update_Jelszo(Elsojelszo_box.Text, Adatbazis.Select_Player_Id(form.User_box.Text));
                Elsojelszo_box.Clear();
                Masodikjelszo_box.Clear();               
                MessageBox.Show("Sikeresen megváltoztatta a jelszót");
            }
            else
            {
                MessageBox.Show("A két jelszó nem egyezik!");
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Login form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Login")
                {
                    form = (Login)item;
                }
            }
            Adatbazis.Delete_Jatekos(Adatbazis.Select_Player_Id(form.User_box.Text));
            Application.Exit();
        }

        private void Vissza_btn_Click(object sender, EventArgs e)
        {
            Basic form = null;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType().ToString() == "Zarodoga.Basic")
                {
                    form = (Basic)item;
                }
            }
            this.Close();
            form.Show();
        }
    }
}
