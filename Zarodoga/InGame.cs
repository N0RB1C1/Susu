using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarodoga
{
    public partial class InGame : Form
    {
        ResourceManager resManager;
        private PictureBox Element_First;
        private PictureBox Element_Second;
        private PictureBox Element_Third;
        List<Ellenseg> creature = new List<Ellenseg>();

        public InGame()
        {
            InitializeComponent();
            resManager = new ResourceManager("Zarodoga.Enemies", GetType().Assembly);
        }

        private void Player_first_element_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p = Cursor.Position;



            // Első választható elem
            Element_First = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(),
                BackColor = Color.Red,               
            };

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

            // Eventek hozzáadása
            Element_First.Click += Element_Change_Click;
            Element_Second.Click += Element_Change_Click;
            Element_Third.Click += Element_Change_Click;
            this.Controls.Remove(Player_first_element);
            this.Controls.Add(Element_First);
            this.Controls.Add(Element_Second);
            this.Controls.Add(Element_Third);
        }

        private void Element_Change_Click(object sender, EventArgs e)
        {
            PictureBox pictruebox = (PictureBox)sender;
            Player_first_element.BackColor = pictruebox.BackColor;
            this.Controls.Add(Player_first_element);
            this.Controls.Remove(Element_First);
            this.Controls.Remove(Element_Second);
            this.Controls.Remove(Element_Third);
        }

        // Enemy auto generate
        private void InGame_Load(object sender, EventArgs e)
        {
            //Véletlenszerű ellenség
            Ellenseg ellen = new Ellenseg();
            creature.Add(ellen);
            Enemy_Label.Text = (
                ellen.Name + "\nEllenség élete: " +
                Convert.ToString(ellen.Healt_Point) + "\nEllenség szintje:  " +
                Convert.ToString(ellen.Level) 
                );

            // Ellenség életerő változtatása
            Enemy_hp.Maximum = ellen.Healt_Point;
            Enemy_hp.Value = ellen.Healt_Point;

            //Kép kiválasztása
            Bitmap kep = (Bitmap)resManager.GetObject(ellen.Name);
            Enemy.BackgroundImage = kep;
            Enemy.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Kör kezdete
        private void Start_Ingame_Click(object sender, EventArgs e)
        {
            Enemy_first_element.BackColor = Color.Red;
            Enemy_second_element.BackColor = Color.Green;
            Enemy_third_element.BackColor = Color.Blue;


        }

        // change is good
    }
}
