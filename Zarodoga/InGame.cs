using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
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
        List<Color> colours = new List<Color>();
        public int tp;


        public InGame()
        {
            InitializeComponent();
            resManager = new ResourceManager("Zarodoga.Enemies", GetType().Assembly);
            this.FormClosing += Form_Closing;
            colours.Add(Color.Aqua);
            colours.Add(Color.LawnGreen);
            colours.Add(Color.Red);
            tp = ellen.Level;

        }

        //Alkalamzás bezárása
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

            //Első element
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

            // Második element
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

            // Harmadik element
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
            if (picturebox.BackColor == Color.Aqua)
            {
                Player_first_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_first_element.BackColor = Color.Aqua;
            }
            else if (picturebox.BackColor == Color.LawnGreen)
            {
                Player_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_first_element.BackColor = Color.LawnGreen;
            }
            else if (picturebox.BackColor == Color.Red)
            {
                Player_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_first_element.BackColor = Color.Red;
            }       
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
            PictureBox picturebox = (PictureBox)sender;

            if (picturebox.BackColor == Color.Aqua)
            {
                Player_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_second_element.BackColor = Color.Aqua;
            }
            else if (picturebox.BackColor == Color.LawnGreen)
            {
                Player_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_second_element.BackColor = Color.LawnGreen;
            }
            else if (picturebox.BackColor == Color.Red)
            {
                Player_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_second_element.BackColor = Color.Red;
            }
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
            PictureBox picturebox = (PictureBox)sender;

            if (picturebox.BackColor == Color.Aqua)
            {
                Player_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_third_element.BackColor = Color.Aqua;
            }
            else if (picturebox.BackColor == Color.LawnGreen)
            {
                Player_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_third_element.BackColor = Color.LawnGreen;
            }
            else if (picturebox.BackColor == Color.Red)
            {
                Player_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                Enemy.BackgroundImageLayout = ImageLayout.Stretch;
                Player_third_element.BackColor = Color.Red;
            }
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
            info_label.Text = (
            "Az ellenség élete: " + Enemy_hp.Value
            + "\nA játékos élete: " + Player_hp.Value
            );
            Enemy_behaviour(ellen.Level);
            Start_Ingame.Visible = false;
            Winner_First.Visible = true;
            Winner_Second.Visible = true;
            Winner_Third.Enabled = true;
            Winner_First.Enabled = true;
            Winner_Second.Enabled = true;
            Winner_Third.Visible = true;
            Spell(Player_first_element, Enemy_first_element);
            Spell(Player_second_element, Enemy_second_element);
            Spell(Player_third_element, Enemy_third_element);

        }

        // Elemek ellenörzése / 0 döntetlen / 1 ellenfél nyer / 2 jatékos nyer
        public int Winner(object player, object enemy)
        {
            PictureBox playerbox = (PictureBox)player;
            PictureBox enemybox = (PictureBox)enemy;
            // Döntetlen
            if (playerbox.BackColor == enemybox.BackColor)
            {
                return 0;
            }
            // Ellenfél nyer
            else if (playerbox.BackColor.Equals(Color.Red) && enemybox.BackColor.Equals(Color.Aqua))
            {
                return 1;
            }
            else if (playerbox.BackColor.Equals(Color.Aqua) && enemybox.BackColor.Equals(Color.LawnGreen))
            {
                return 1;
            }

            else if (playerbox.BackColor.Equals(Color.LawnGreen) && enemybox.BackColor.Equals(Color.Red))
            {
                return 1;
            }
            // Játékos nyer
            else if (playerbox.BackColor.Equals(Color.LawnGreen) && enemybox.BackColor.Equals(Color.Aqua))
            {
                return 2;
            }
            else if (playerbox.BackColor.Equals(Color.Red) && enemybox.BackColor.Equals(Color.LawnGreen))
            {
                return 2;
            }
            else if (playerbox.BackColor.Equals(Color.Aqua) && enemybox.BackColor.Equals(Color.Red))
            {
                return 2;
            }
            return 0;
        }

        // Ellenfél viselkedése
        public void Enemy_behaviour(int level)
        {
            switch (level)
            {

                case 1:
                    Random r0 = new Random();
                    int rand = r0.Next(0, 3);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.Aqua;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_third_element.BackColor = Color.Red;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    break;

                case 2:
                    Random r1 = new Random();
                    rand = r1.Next(0, 4);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.Red;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    else if (rand == 2)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    break;

                case 3:

                    Random r2 = new Random();
                    rand = r2.Next(0, 7);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.Red;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.Aqua;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (rand == 2)
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (rand == 3)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (rand == 4)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (rand == 5)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    break;

                case 4:
                    Random r3 = new Random();
                    rand = r3.Next(0, 5);
                    if (rand == 0)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (rand == 1)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (rand == 2)
                    {
                        Enemy_first_element.BackColor = Color.Red;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_third_element.BackColor = Color.Aqua;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (rand == 3)
                    {
                        Enemy_first_element.BackColor = Color.Aqua;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_second_element.BackColor = Color.LawnGreen;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_third_element.BackColor = Color.Red;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    else if (rand == 4)
                    {
                        Enemy_first_element.BackColor = Color.Aqua;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_second_element.BackColor = Color.Red;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                        Enemy_third_element.BackColor = Color.LawnGreen;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else 
                    {
                        Enemy_first_element.BackColor = Color.LawnGreen;
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                        Enemy_second_element.BackColor = Color.Aqua;
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                        Enemy_third_element.BackColor = Color.Red;
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    break;

                case 5:

                    Random r4 = new Random();
                    rand = r4.Next(0, 2);
                    Enemy_first_element.BackColor = colours[rand];
                    if (Enemy_first_element.BackColor == Color.Aqua)
                    {
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (Enemy_first_element.BackColor == Color.LawnGreen)
                    {
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (Enemy_first_element.BackColor == Color.Red)
                    {
                        Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    rand = r4.Next(0, 2);
                    Enemy_second_element.BackColor = colours[rand];
                    if (Enemy_second_element.BackColor == Color.Aqua)
                    {
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (Enemy_second_element.BackColor == Color.LawnGreen)
                    {
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (Enemy_second_element.BackColor == Color.Red)
                    {
                        Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    rand = r4.Next(0, 2);
                    Enemy_third_element.BackColor = colours[rand];
                    if (Enemy_third_element.BackColor == Color.Aqua)
                    {
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Drop;
                    }
                    else if (Enemy_third_element.BackColor == Color.LawnGreen)
                    {
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Leaf;
                    }
                    else if (Enemy_third_element.BackColor == Color.Red)
                    {
                        Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Fire;
                    }
                    break;

                default:
                    Enemy_first_element.BackColor = Color.Aqua;
                    Enemy_second_element.BackColor = Color.Aqua;
                    Enemy_third_element.BackColor = Color.Aqua;
                    break;
            }

        }

        //Győztes ellenörzése
        private void Round_Start(object spell)
        {
            PictureBox winner = (PictureBox)spell;
            if (winner.Tag.Equals("Fire_spell"))
            {
                Player_hp.Value = Player_hp.Value - 10;
            }
            else if (winner.Tag.Equals("Frost_spell_res"))
            {
                Player_hp.Value = Player_hp.Value - 10;
            }
            else if (winner.Tag.Equals("Leaf_spell_res"))
            {
                Player_hp.Value = Player_hp.Value - 10;
            }
            else if (winner.Tag.Equals("Fire_spell_res"))
            {
                Enemy_hp.Value = Enemy_hp.Value - 10;
            }
            else if (winner.Tag.Equals("Frost_spell"))
            {
                Enemy_hp.Value = Enemy_hp.Value - 10;
            }
            else if (winner.Tag.Equals("Leaf_spell"))
            {
                Enemy_hp.Value = Enemy_hp.Value - 10;
            }
            else
            {
                Enemy_hp.Value = Enemy_hp.Value + 0;
            }

        }

        // Thick event
        private void Round_Tick(object sender, EventArgs e)
        {

        }

        // Megjeleníti a spelleket
        private void Spell(object player, object enemy)
        {
            PictureBox playerbox = (PictureBox)player;
            PictureBox enemybox = (PictureBox)enemy;
            if (Winner(playerbox, enemybox) == 1)
            {
                if (playerbox == Player_first_element)
                {
                    if (playerbox.BackColor == Color.LawnGreen)
                    {
                        Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Fire_spell;
                        Winner_First.Tag = "Fire_spell";
                    }
                    else if (playerbox.BackColor == Color.Aqua)
                    {
                        Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Leaf_spell_res;
                        Winner_First.Tag = "Leaf_spell_res";
                    }
                    else if (playerbox.BackColor == Color.Red)
                    {
                        Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Frost_spell_res;
                        Winner_First.Tag = "Frost_spell_res";
                    }
                }
                else if (playerbox == Player_second_element)
                {
                    if (playerbox.BackColor == Color.LawnGreen)
                    {
                        Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Fire_spell;
                        Winner_Second.Tag = "Fire_spell";
                    }
                    else if (playerbox.BackColor == Color.Aqua)
                    {
                        Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Leaf_spell_res;
                        Winner_Second.Tag = "Leaf_spell_res";
                    }
                    else if (playerbox.BackColor == Color.Red)
                    {
                        Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Frost_spell_res;
                        Winner_Second.Tag = "Frost_spell_res";
                    }
                }
                else if (playerbox == Player_third_element)
                {
                    if (playerbox.BackColor == Color.LawnGreen)
                    {
                        Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Fire_spell;
                        Winner_Third.Tag = "Fire_spell";
                    }
                    else if (playerbox.BackColor == Color.Aqua)
                    {
                        Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Leaf_spell_res;
                        Winner_Third.Tag = "Leaf_spell_res";
                    }
                    else if (playerbox.BackColor == Color.Red)
                    {
                        Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Frost_spell_res;
                        Winner_Third.Tag = "Frost_spell_res";
                    }
                }
            }
            else if (Winner(playerbox,enemybox) == 2)
            {
                if (player == Player_first_element)
                {
                    if (playerbox.BackColor == Color.LawnGreen)
                    {
                        Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Leaf_spell;
                        Winner_First.Tag = "Leaf_spell";
                    }
                    else if (playerbox.BackColor == Color.Aqua)
                    {
                        Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Frost_spell;
                        Winner_First.Tag = "Frost_spell";
                    }
                    else if (playerbox.BackColor == Color.Red)
                    {
                        Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Fire_spell_res;
                        Winner_First.Tag = "Fire_spell_res";
                    }
                }
                else if (playerbox == Player_second_element)
                {
                    if (playerbox.BackColor == Color.LawnGreen)
                    {
                        Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Leaf_spell;
                        Winner_Second.Tag = "Leaf_spell";
                    }
                    else if (playerbox.BackColor == Color.Aqua)
                    {
                        Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Frost_spell;
                        Winner_Second.Tag = "Frost_spell";
                    }
                    else if (playerbox.BackColor == Color.Red)
                    {
                        Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Fire_spell_res;
                        Winner_Second.Tag = "Fire_spell_res";
                    }
                }
                else if (playerbox == Player_third_element)
                {
                    if (playerbox.BackColor == Color.LawnGreen)
                    {
                        Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Leaf_spell;
                        Winner_Third.Tag = "Leaf_spell";
                    }
                    else if (playerbox.BackColor == Color.Aqua)
                    {
                        Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Frost_spell;
                        Winner_Third.Tag = "Frost_spell";
                    }
                    else if (playerbox.BackColor == Color.Red)
                    {
                        Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Fire_spell_res;
                        Winner_Third.Tag = "Fire_spell_res";
                    }
                }
            }
            else
            {
                if (playerbox == Player_first_element)
                {
                    Winner_First.BackgroundImage = Zarodoga.Properties.Resources.Draw;
                    Winner_First.Tag = "Draw";
                }
                else if (playerbox == Player_second_element)
                {
                    Winner_Second.BackgroundImage = Zarodoga.Properties.Resources.Draw;
                    Winner_Second.Tag = "Draw";
                }
                if (playerbox == Player_third_element)
                {
                    Winner_Third.BackgroundImage = Zarodoga.Properties.Resources.Draw;
                    Winner_Third.Tag = "Draw";
                }
            }

        }

        // Életerő ellenörzés
        private bool Hp_Check()
        {
            bool win = true;
            if (Player_hp.Value == 0)
            {
                win = false;
                return win;
            }
            else if (Enemy_hp.Value == 0)
            {
                win = false;
                return win;
            }
            return win;
        }

        // Loot ablak nyitása
        private void Loot_Form()
        {
            // Lose
            if (Player_hp.Value == 0)
            {
                Start_Ingame.Enabled = false;
                Loot form = new Loot();
                form.tapasztalatipont = ellen.Level * 5;
                form.End.Text = "Vereség";
                form.Show();

            }
            // Victory
            else if (Enemy_hp.Value == 0)
            {

                Start_Ingame.Enabled = false;
                Loot form = new Loot();
                form.tapasztalatipont = ellen.Level * 10;
                form.End.Text = "Győzelem";
                form.Show();

            }
        }

        // Spell katt
        private void Winner_First_Click(object sender, EventArgs e)
        {
            Round_Start(Winner_First);
            Winner_First.Enabled = false;
            Winner_First.Visible = false;

            if (Winner_First.Enabled == false && Winner_Second.Enabled == false && Winner_Third.Enabled == false)
            {
                Start_Ingame.Visible = true;
                Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
                Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
                Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
            }
            if (Hp_Check() == false)
            {
                Loot_Form();
            }
        }

        private void Winner_Second_Click(object sender, EventArgs e)
        {
            Round_Start(Winner_Second);
            Winner_Second.Enabled = false;
            Winner_Second.Visible = false;
            if (Winner_First.Enabled == false && Winner_Second.Enabled == false && Winner_Third.Enabled == false)
            {
                Start_Ingame.Visible = true;
                Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
                Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
                Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
            }

            if (Hp_Check() == false)
            {
                Loot_Form();
            }
        }

        private void Winner_Third_Click(object sender, EventArgs e)
        {
            Round_Start(Winner_Third);
            Winner_Third.Enabled = false;
            Winner_Third.Visible = false;
            if (Winner_First.Enabled == false && Winner_Second.Enabled == false && Winner_Third.Enabled == false)
            {
                Start_Ingame.Visible = true;
                Enemy_first_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
                Enemy_second_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
                Enemy_third_element.BackgroundImage = Zarodoga.Properties.Resources.Elements_rotate;
            }
            if (Hp_Check() == false)
            {
                Loot_Form();
            }
        }


        // change is good
    }
}
