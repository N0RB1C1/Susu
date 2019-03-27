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
            this.FormClosing += Exit_Button_Click;
        }

        // Alkalmazás bezárása 
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();           
        }

        // Playing 
        private void Start_Button_Click(object sender, EventArgs e)
        {
            InGame form = new InGame();
            this.Hide();
            form.ShowDialog();
            
        }

        private void Basic_Load(object sender, EventArgs e)
        {
            Login form = new Login();
            int i = Adatbazis.Select_Player_Id(form.User_box.Text);
            p = new Player(form.User_box.Text,
                Adatbazis.Select_Player_Id(form.User_box.Text),
                Adatbazis.Select_Player_Arany(i),
                Adatbazis.Select_Player_Tapasztalati_Pont(i),
                Adatbazis.Select_Player_Jogosultsag(i),
                Adatbazis.Select_Player_Palya(i)
                );
            Arany.Text += p.arany;
            Loot form2 = new Loot();
            Szint.Value = form2.tapasztalatipont;
            Player_info.Text += p.username;
        }


    }
}
