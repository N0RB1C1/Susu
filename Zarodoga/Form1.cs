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
    public partial class Form_1 : Form
    {
        public Form_1()
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
                Adatbazis.InsertInto(User_box.Text, Pass_box.Text);
                User_box.Clear();
                Pass_box.Clear();
            }
            else
            {
                string message = "Nem töltött ki egy mezőt";
                string caption = "Form Closing";
                MessageBox.Show(message,caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Adatbazis.Select(User_box.Text, Pass_box.Text) == 0)
            {
                string message = "Invalid vagy!";
                string caption = "Form Closing";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = "Ügyes vagy!";
                string caption = "Form Closing";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
