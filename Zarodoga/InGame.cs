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
        private static int marker;
        Ellenseg ellen = new Ellenseg();

        public InGame()
        {
            InitializeComponent();
            resManager = new ResourceManager("Zarodoga.Enemies", GetType().Assembly);
        }

        // Első elem választása
        private void Player_element_Click(object sender, EventArgs e)
        {
            PictureBox pictruebox = (PictureBox)sender;
            
            // Első választható elem
            Element_First = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(pictruebox.Location.X+10,pictruebox.Location.Y+20),
                BackColor = Color.Red,               
            };

            // Második választható elem 
            Element_Second = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(pictruebox.Location.X + 70, pictruebox.Location.Y + 20),
                BackColor = Color.Aqua
            };

            // Harmadik választható elem 
            Element_Third = new PictureBox
            {
                Name = "Element_Choose",
                Size = new Size(15, 15),
                Location = new Point(pictruebox.Location.X + 40, pictruebox.Location.Y + 70),
                BackColor = Color.LawnGreen
            };
            if (pictruebox.Equals(Player_first_element))
            {
                marker = 1;
            }
            else if (pictruebox.Equals(Player_second_element))
            {
                marker = 2;
            }
            else marker = 3;

            // Eventek hozzáadása
            Element_First.Click += Element_Change_Click;
            Element_Second.Click += Element_Change_Click;
            Element_Third.Click += Element_Change_Click;
            this.Controls.Remove(pictruebox);
            this.Controls.Add(Element_First);
            this.Controls.Add(Element_Second);
            this.Controls.Add(Element_Third);
        }

        // Kis ikon katt event
        private void Element_Change_Click(object sender, EventArgs e)
        {
            PictureBox pictruebox = (PictureBox)sender;
            if(marker == 1)
            {
                Player_first_element.BackColor = pictruebox.BackColor;
                this.Controls.Add(Player_first_element);
            }
            else if (marker == 2)
            {
                Player_second_element.BackColor = pictruebox.BackColor;
                this.Controls.Add(Player_second_element);
            }
            else if (marker == 3)
            {
                Player_third_element.BackColor = pictruebox.BackColor;
                this.Controls.Add(Player_third_element);
            }
            this.Controls.Remove(Element_First);
            this.Controls.Remove(Element_Second);
            this.Controls.Remove(Element_Third);
        }

        // Enemy auto generate
        private void InGame_Load(object sender, EventArgs e)
        {
            //Véletlenszerű ellenség
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
            this.Controls.Remove(Start_Ingame);
            if (ellen.level_one_enemy_behaviour() == 1)
            {
                Enemy_first_element.BackColor = Color.Red;
                Enemy_second_element.BackColor = Color.Red;
                Enemy_third_element.BackColor = Color.Red;
            }
            else if(ellen.level_one_enemy_behaviour() == 2)
            {
                Enemy_first_element.BackColor = Color.LawnGreen;
                Enemy_second_element.BackColor = Color.LawnGreen;
                Enemy_third_element.BackColor = Color.LawnGreen;
            }
            else
            {
                Enemy_first_element.BackColor = Color.Aqua;
                Enemy_second_element.BackColor = Color.Aqua;
                Enemy_third_element.BackColor = Color.Aqua;
            }
            if (Player_hp.Value > 0)
            {
                if (winner(Player_first_element, Enemy_first_element) == 1)
                {
                    Player_hp.Value = Player_hp.Value - 20;
                }
            }
            this.Controls.Add(Start_Ingame);
        }

        public int winner(object a, object b)
        {
            PictureBox pictruebox = (PictureBox)a;
            PictureBox pictruebox2 = (PictureBox)b;
            int win;
            if (pictruebox.BackColor == pictruebox2.BackColor)
            {
                return 0;
            }
            return 1;
        }

        // change is good
    }
}
