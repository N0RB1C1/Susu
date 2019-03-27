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
    public partial class Loot : Form
    {
        public int tapasztalatipont;
        public int sumtp;
        public int arany;

        public Loot()
        {
            InitializeComponent();
            this.FormClosing += Pick_up_loot_Click;
            
        }

        private void Loot_Load(object sender, EventArgs e)
        {
            sumtp += tapasztalatipont;
            if (End.Text.Equals("Győzelem"))
            {
                BackColor = Color.DarkGreen;
            }
            else if (End.Text.Equals("Vereség"))
            {
                BackColor = Color.DarkRed;
            }
            Loot_label.Text = "Tapasztalati pont: " + tapasztalatipont +"\nArany: " + arany;
        }

        private void Pick_up_loot_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            Adatbazis.Update(Adatbazis.Select_Player_Id(form.User_box.Text), tapasztalatipont);
            this.Hide();
            InGame.ActiveForm.Hide();
            Basic form2 = new Basic();
            form2.ShowDialog();
            
        }
    }
}
