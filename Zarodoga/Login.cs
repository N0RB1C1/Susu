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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Adatbazis.Adatbazisletrehozas();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {

            if (!User_box.Text.Equals("") && !Pass_box.Text.Equals(""))
            {
                if (Adatbazis.RegisterCheck(User_box.Text) == 0)
                {
                    Adatbazis.InsertInto_Player(User_box.Text, Pass_box.Text);
                    Adatbazis.InsertInto_Loot(User_box.Text);
                    User_box.Clear();
                    Pass_box.Clear();
                    MessageBox.Show("Sikeres regisztráció!");
                }
                else
                {
                    string message = "Van már ilyen felhasználónév!";
                    string caption = "Form Closing";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string message = "Nem töltött ki egy mezőt";
                string caption = "Form Closing";
                MessageBox.Show(message,caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {

            if (Adatbazis.Select(User_box.Text, Pass_box.Text) == 0)
            {
                string message = "Nem megfelő a felhasználónév vagy a jelszó!";
                string caption = "Form Closing";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Basic form = new Basic();               
                this.Hide();             
                form.ShowDialog();
            }
            
        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
