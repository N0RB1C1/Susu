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
        private PictureBox Element_Fourth;
        private PictureBox Element_Fiveth;
        private PictureBox Element_Sixth;
        private PictureBox Element_Seventh;
        private PictureBox Element_Eighth;
        private PictureBox Element_Nineth;
        List<Ellenseg> creature = new List<Ellenseg>();
        Ellenseg ellen = new Ellenseg();
        new List<Color> colours = new List<Color>();


        public InGame()
        {
            InitializeComponent();
            resManager = new ResourceManager("Zarodoga.Enemies", GetType().Assembly);
            colours.Add(Color.Aqua);
            colours.Add(Color.LawnGreen);
            colours.Add(Color.Red);

        }

        // Első elem választása
        private void Player_element_Click(object sender, EventArgs e)
        {
            PictureBox picturebox = (PictureBox)sender;
            Start_Ingame.Enabled = false;
            // Első elemek kiválasztása
            if (picturebox.Equals(Player_first_element))
            {
                // Első kisikon /1
                Element_First = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 10, picturebox.Location.Y + 20),
                    BackColor = Color.Red,
                };

                // Második kisikon /1
                Element_Second = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 70, picturebox.Location.Y + 20),
                    BackColor = Color.Aqua,
                };

                // Harmadik kisikon /1
                Element_Third = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 40, picturebox.Location.Y + 70),
                    BackColor = Color.LawnGreen,
                };
            }

            // Második elemek kiválasztása
            else if (picturebox.Equals(Player_second_element))
            {
                // Első kisikon /2
                Element_Fourth = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 10, picturebox.Location.Y + 20),
                    BackColor = Color.Red,
                };

                // Második kisikon /2
                Element_Fiveth = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 70, picturebox.Location.Y + 20),
                    BackColor = Color.Aqua,
                };

                // Harmadik kisikon /2
                Element_Sixth = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 40, picturebox.Location.Y + 70),
                    BackColor = Color.LawnGreen,
                };
            }

            // Harmadik elemek kiválasztása
            else if (picturebox.Equals(Player_third_element))
            {
                // Első kisikon /3
                Element_Seventh = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 10, picturebox.Location.Y + 20),
                    BackColor = Color.Red,
                };

                // Második kisikon /3
                Element_Eighth = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 70, picturebox.Location.Y + 20),
                    BackColor = Color.Aqua,
                };

                // Harmadik kisikon /3
                Element_Nineth = new PictureBox
                {
                    Name = "Element_Choose",
                    Size = new Size(15, 15),
                    Location = new Point(picturebox.Location.X + 40, picturebox.Location.Y + 70),
                    BackColor = Color.LawnGreen,
                };
            }


            if (picturebox.Equals(Player_first_element))
            {
                // Eventek hozzáadása
                Element_First.Click += Element_First_Change_Click;
                Element_Second.Click += Element_First_Change_Click;
                Element_Third.Click += Element_First_Change_Click;
                this.Controls.Remove(picturebox);
                this.Controls.Add(Element_First);
                this.Controls.Add(Element_Second);
                this.Controls.Add(Element_Third);
            }

            else if (picturebox.Equals(Player_second_element))
            {
                // Eventek hozzáadása
                Element_Fourth.Click += Element_Second_Change_Click;
                Element_Fiveth.Click += Element_Second_Change_Click;
                Element_Sixth.Click += Element_Second_Change_Click;
                this.Controls.Remove(picturebox);
                this.Controls.Add(Element_Fourth);
                this.Controls.Add(Element_Fiveth);
                this.Controls.Add(Element_Sixth);
            }

            else if (picturebox.Equals(Player_third_element))
            {
                // Eventek hozzáadása
                Element_Seventh.Click += Element_Third_Change_Click;
                Element_Eighth.Click += Element_Third_Change_Click;
                Element_Nineth.Click += Element_Third_Change_Click;
                this.Controls.Remove(picturebox);
                this.Controls.Add(Element_Seventh);
                this.Controls.Add(Element_Eighth);
                this.Controls.Add(Element_Nineth);
            }
        }

        // Kis ikon katt eventek 
        private void Element_First_Change_Click(object sender, EventArgs e)
        {
            PictureBox picturebox = (PictureBox)sender;

            Player_first_element.BackColor = picturebox.BackColor;
            Player_first_element.BackgroundImage = null;
            this.Controls.Add(Player_first_element);           
            this.Controls.Remove(Element_First);
            this.Controls.Remove(Element_Second);
            this.Controls.Remove(Element_Third);
            if (!Player_first_element.BackColor.Equals(Color.White) && !Player_second_element.BackColor.Equals(Color.White) && !Player_third_element.BackColor.Equals(Color.White))
            {
                Start_Ingame.Enabled = true;
            }

        }
        private void Element_Second_Change_Click(object sender, EventArgs e)
        {
            PictureBox pictruebox = (PictureBox)sender;

            Player_second_element.BackColor = pictruebox.BackColor;
            Player_second_element.BackgroundImage = null;
            this.Controls.Add(Player_second_element);
            this.Controls.Remove(Element_Fourth);
            this.Controls.Remove(Element_Fiveth);
            this.Controls.Remove(Element_Sixth);
            if (!Player_first_element.BackColor.Equals(Color.White) && !Player_second_element.BackColor.Equals(Color.White) && !Player_third_element.BackColor.Equals(Color.White))
            {
                Start_Ingame.Enabled = true;
            }
        }
        private void Element_Third_Change_Click(object sender, EventArgs e)
        {
            PictureBox pictruebox = (PictureBox)sender;

            Player_third_element.BackColor = pictruebox.BackColor;
            Player_third_element.BackgroundImage = null;
            this.Controls.Add(Player_third_element);
            this.Controls.Remove(Element_Seventh);
            this.Controls.Remove(Element_Eighth);
            this.Controls.Remove(Element_Nineth);
            if (!Player_first_element.BackColor.Equals(Color.White) && !Player_second_element.BackColor.Equals(Color.White) && !Player_third_element.BackColor.Equals(Color.White))
            {
                Start_Ingame.Enabled = true;
            }
        }

        // Enemy auto generate
        private void InGame_Load(object sender, EventArgs e)
        {
            Start_Ingame.Enabled = false;

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
            Enemy_behaviour(ellen.Level);

            // Életerő ellenörzés
            if (Player_hp.Value > 0 && Enemy_hp.Value > 0)
            {

                // Első elem ellenörzés
                if (winner(Player_first_element, Enemy_first_element) == 1)
                {
                    Player_hp.Value = Player_hp.Value - 10;
                }

                else if (winner(Player_first_element, Enemy_first_element) == 2)
                {
                    Enemy_hp.Value = Enemy_hp.Value - 10;
                }
            }
            // Életerő ellenörzés
            if (Player_hp.Value > 0 && Enemy_hp.Value > 0)
            {
                // Második elem ellenörzése
                if (winner(Player_second_element, Enemy_second_element) == 1)
                {
                    Player_hp.Value = Player_hp.Value - 10;
                }
                else if (winner(Player_second_element, Enemy_second_element) == 2)
                {
                    Enemy_hp.Value = Enemy_hp.Value - 10;
                }
            }
            // Életerő ellenörzés
            if (Player_hp.Value > 0 && Enemy_hp.Value > 0)
            {

                // Harmadik elem ellenörzése
                if (winner(Player_third_element, Enemy_third_element) == 1)
                {
                    Player_hp.Value = Player_hp.Value - 10;
                }

                else if (winner(Player_third_element, Enemy_third_element) == 2)
                {
                    Enemy_hp.Value = Enemy_hp.Value - 10;
                }
            }
            
            if (Player_hp.Value == 0)
            {
                Start_Ingame.Enabled = false;
                Loot form = new Loot();
                form.BackColor.Equals(Color.DarkRed);
                form.Show();                            
            }
            else if (Enemy_hp. Value == 0)
            {
                Start_Ingame.Enabled = false;
                Loot form = new Loot();
                form.BackColor.Equals(Color.DarkGreen);
                form.Show();
            }

            info_label.Text = (
            "Az ellenség élete: " + Enemy_hp.Value
            + "\nA játékos élete: " + Player_hp.Value
            );
            
        }

        // Elemek ellenörzése
        public int winner(object a, object b)
        {
            PictureBox player = (PictureBox)a;
            PictureBox enemy = (PictureBox)b;
            
            if (player.BackColor == enemy.BackColor)
            {
                return 0;
            }

            else if (player.BackColor.Equals(Color.Aqua) && enemy.BackColor.Equals(Color.Red))
            {
                return 2;
            }

            else if (player.BackColor.Equals(Color.Aqua) && enemy.BackColor.Equals(Color.LawnGreen))
            {
                return 1;
            }

            else if (player.BackColor.Equals(Color.LawnGreen) && enemy.BackColor.Equals(Color.Red))
            {
                return 1;
            }

            else if (player.BackColor.Equals(Color.LawnGreen) && enemy.BackColor.Equals(Color.Aqua))
            {
                return 2;
            }

            else if (player.BackColor.Equals(Color.Red) && enemy.BackColor.Equals(Color.Aqua))
            {
                return 1;
            }

            else if (player.BackColor.Equals(Color.Red) && enemy.BackColor.Equals(Color.LawnGreen))
            {
                return 2;
            }


            return 0;    
        }

        private void Round_Tick(object sender, EventArgs e)
        {
            int a = 0;
            a++;
            if (a > 5)
            {
                Round.Tag = "Stop";
            }
        }

        // Ellenfél viselkedése
        public void Enemy_behaviour(int level)
        {
            switch (level)
            {

                case 1:
                    Random r0 = new Random();
                    int rand;
                    rand = r0.Next(0, 3);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.Aqua;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                    }
                    else
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_third_element.BackColor = Color.Red;
                    }
                    break;

                case 2:
                    Random r1 = new Random();
                    rand = r1.Next(0, 4);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_third_element.BackColor = Color.Aqua;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.Red;
                    }
                    else if (rand == 2)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                    }
                    else
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackColor = Color.Aqua;
                    }
                    break;

                case 3:

                    Random r2 = new Random();
                    rand = r2.Next(0, 7);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.Red;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_third_element.BackColor = Color.Aqua;
                    }
                    else if (rand == 2)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                    }
                    else if (rand == 3)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                    }
                    else if (rand == 4)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.Aqua;
                    }
                    else if (rand == 5)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                    }
                    else
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackColor = Color.Aqua;
                    }
                    break;

                case 4:
                    Random r3 = new Random();
                    rand = r3.Next(0, 2);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                    }

                    break;

                case 5:
                                   
                    Random r4 = new Random();
                    rand = r4.Next(0, 2);
                    Enemy_first_element.BackColor = colours[rand];
                    rand = r4.Next(0, 2);
                    Enemy_second_element.BackColor = colours[rand];
                    rand = r4.Next(0, 2);
                    Enemy_third_element.BackColor = colours[rand];
                    break;

                default:              
                    Enemy_first_element.BackColor = Color.Aqua;
                    Enemy_second_element.BackColor = Color.Aqua;
                    Enemy_third_element.BackColor = Color.Aqua;
                    break;
            }
                 
        }
        // change is good
    }
}
