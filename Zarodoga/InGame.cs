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
    public partial class InGame : Form
    {
        private PictureBox Element_First;
        private PictureBox Element_Second;
        private PictureBox Element_Third;
        public InGame()
        {
            InitializeComponent();
        }

        private void Player_first_element_Click(object sender, EventArgs e)
        {
            // Első választható elem
            Element_First = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(65, 330),
                BackColor = Color.Red,               
            };
            Element_First.Click += Element_First_Click;

            // Második választható elem 
            Element_Second = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(130, 330),
                BackColor = Color.Aqua
            };

            // Harmadik választható elem 
            Element_Third = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(100, 370),
                BackColor = Color.LawnGreen
            };

            this.Controls.Remove(Player_first_element);
            this.Controls.Add(Element_First);
            this.Controls.Add(Element_Second);
            this.Controls.Add(Element_Third);
        }

        private void Element_First_Click(object sender, EventArgs e)
        {
            Player_first_element.BackColor = Element_First.BackColor;
            this.Controls.Add(Player_first_element);
            this.Controls.Remove(Element_First);
            this.Controls.Remove(Element_Second);
            this.Controls.Remove(Element_Third);
        }
        // change is good
    }
}
