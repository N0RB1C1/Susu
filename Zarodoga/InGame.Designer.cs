using System;

namespace Zarodoga
{
    partial class InGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Player_hp = new System.Windows.Forms.ProgressBar();
            this.Enemy_hp = new System.Windows.Forms.ProgressBar();
            this.Player_first_element = new System.Windows.Forms.PictureBox();
            this.Player_second_element = new System.Windows.Forms.PictureBox();
            this.Player_third_element = new System.Windows.Forms.PictureBox();
            this.Enemy_second_element = new System.Windows.Forms.PictureBox();
            this.Enemy_first_element = new System.Windows.Forms.PictureBox();
            this.Enemy_third_element = new System.Windows.Forms.PictureBox();
            this.Start_Ingame = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.Round = new System.Windows.Forms.Timer(this.components);
            this.Winner_First = new System.Windows.Forms.PictureBox();
            this.Winner_Third = new System.Windows.Forms.PictureBox();
            this.Winner_Second = new System.Windows.Forms.PictureBox();
            this.Gyors_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_first_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_second_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_third_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_second_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_first_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_third_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winner_First)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winner_Third)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winner_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackgroundImage = global::Zarodoga.Properties.Resources.Hero;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(169, 541);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 115);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.BackgroundImage = global::Zarodoga.Properties.Resources.Ooze;
            this.Enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy.Location = new System.Drawing.Point(169, 12);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(100, 115);
            this.Enemy.TabIndex = 0;
            this.Enemy.TabStop = false;
            // 
            // Player_hp
            // 
            this.Player_hp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Player_hp.ForeColor = System.Drawing.Color.White;
            this.Player_hp.Location = new System.Drawing.Point(169, 515);
            this.Player_hp.Name = "Player_hp";
            this.Player_hp.Size = new System.Drawing.Size(100, 20);
            this.Player_hp.TabIndex = 1;
            this.Player_hp.Value = 100;
            // 
            // Enemy_hp
            // 
            this.Enemy_hp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Enemy_hp.ForeColor = System.Drawing.Color.White;
            this.Enemy_hp.Location = new System.Drawing.Point(169, 133);
            this.Enemy_hp.Name = "Enemy_hp";
            this.Enemy_hp.Size = new System.Drawing.Size(100, 20);
            this.Enemy_hp.TabIndex = 1;
            this.Enemy_hp.Value = 100;
            // 
            // Player_first_element
            // 
            this.Player_first_element.BackColor = System.Drawing.Color.White;
            this.Player_first_element.BackgroundImage = global::Zarodoga.Properties.Resources.Elements;
            this.Player_first_element.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player_first_element.Location = new System.Drawing.Point(45, 364);
            this.Player_first_element.Name = "Player_first_element";
            this.Player_first_element.Size = new System.Drawing.Size(100, 145);
            this.Player_first_element.TabIndex = 2;
            this.Player_first_element.TabStop = false;
            this.Player_first_element.Click += new System.EventHandler(this.Player_element_Click);
            // 
            // Player_second_element
            // 
            this.Player_second_element.BackColor = System.Drawing.Color.White;
            this.Player_second_element.BackgroundImage = global::Zarodoga.Properties.Resources.Elements;
            this.Player_second_element.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player_second_element.Location = new System.Drawing.Point(169, 364);
            this.Player_second_element.Name = "Player_second_element";
            this.Player_second_element.Size = new System.Drawing.Size(100, 145);
            this.Player_second_element.TabIndex = 2;
            this.Player_second_element.TabStop = false;
            this.Player_second_element.Click += new System.EventHandler(this.Player_element_Click);
            // 
            // Player_third_element
            // 
            this.Player_third_element.BackColor = System.Drawing.Color.White;
            this.Player_third_element.BackgroundImage = global::Zarodoga.Properties.Resources.Elements;
            this.Player_third_element.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player_third_element.Location = new System.Drawing.Point(291, 364);
            this.Player_third_element.Name = "Player_third_element";
            this.Player_third_element.Padding = new System.Windows.Forms.Padding(3);
            this.Player_third_element.Size = new System.Drawing.Size(100, 145);
            this.Player_third_element.TabIndex = 2;
            this.Player_third_element.TabStop = false;
            this.Player_third_element.Click += new System.EventHandler(this.Player_element_Click);
            // 
            // Enemy_second_element
            // 
            this.Enemy_second_element.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_second_element.BackgroundImage = global::Zarodoga.Properties.Resources.Elements_rotate;
            this.Enemy_second_element.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy_second_element.Location = new System.Drawing.Point(169, 159);
            this.Enemy_second_element.Name = "Enemy_second_element";
            this.Enemy_second_element.Size = new System.Drawing.Size(100, 145);
            this.Enemy_second_element.TabIndex = 2;
            this.Enemy_second_element.TabStop = false;
            // 
            // Enemy_first_element
            // 
            this.Enemy_first_element.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_first_element.BackgroundImage = global::Zarodoga.Properties.Resources.Elements_rotate;
            this.Enemy_first_element.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy_first_element.Location = new System.Drawing.Point(45, 159);
            this.Enemy_first_element.Name = "Enemy_first_element";
            this.Enemy_first_element.Size = new System.Drawing.Size(100, 145);
            this.Enemy_first_element.TabIndex = 2;
            this.Enemy_first_element.TabStop = false;
            // 
            // Enemy_third_element
            // 
            this.Enemy_third_element.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_third_element.BackgroundImage = global::Zarodoga.Properties.Resources.Elements_rotate;
            this.Enemy_third_element.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy_third_element.Location = new System.Drawing.Point(291, 159);
            this.Enemy_third_element.Name = "Enemy_third_element";
            this.Enemy_third_element.Size = new System.Drawing.Size(100, 145);
            this.Enemy_third_element.TabIndex = 2;
            this.Enemy_third_element.TabStop = false;
            // 
            // Start_Ingame
            // 
            this.Start_Ingame.Location = new System.Drawing.Point(169, 322);
            this.Start_Ingame.Name = "Start_Ingame";
            this.Start_Ingame.Size = new System.Drawing.Size(100, 23);
            this.Start_Ingame.TabIndex = 4;
            this.Start_Ingame.Text = "Start";
            this.Start_Ingame.UseVisualStyleBackColor = true;
            this.Start_Ingame.Click += new System.EventHandler(this.Start_Ingame_Click);
            // 
            // info_label
            // 
            this.info_label.BackColor = System.Drawing.Color.Transparent;
            this.info_label.Image = ((System.Drawing.Image)(resources.GetObject("info_label.Image")));
            this.info_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.info_label.Location = new System.Drawing.Point(291, 542);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(100, 115);
            this.info_label.TabIndex = 5;
            this.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Winner_First
            // 
            this.Winner_First.BackColor = System.Drawing.Color.Transparent;
            this.Winner_First.Location = new System.Drawing.Point(45, 310);
            this.Winner_First.Name = "Winner_First";
            this.Winner_First.Size = new System.Drawing.Size(100, 48);
            this.Winner_First.TabIndex = 6;
            this.Winner_First.TabStop = false;
            this.Winner_First.Visible = false;
            this.Winner_First.Click += new System.EventHandler(this.Winner_First_Click);
            // 
            // Winner_Third
            // 
            this.Winner_Third.BackColor = System.Drawing.Color.Transparent;
            this.Winner_Third.Location = new System.Drawing.Point(291, 310);
            this.Winner_Third.Name = "Winner_Third";
            this.Winner_Third.Size = new System.Drawing.Size(100, 48);
            this.Winner_Third.TabIndex = 6;
            this.Winner_Third.TabStop = false;
            this.Winner_Third.Visible = false;
            this.Winner_Third.Click += new System.EventHandler(this.Winner_Third_Click);
            // 
            // Winner_Second
            // 
            this.Winner_Second.BackColor = System.Drawing.Color.Transparent;
            this.Winner_Second.Location = new System.Drawing.Point(169, 310);
            this.Winner_Second.Name = "Winner_Second";
            this.Winner_Second.Size = new System.Drawing.Size(100, 48);
            this.Winner_Second.TabIndex = 6;
            this.Winner_Second.TabStop = false;
            this.Winner_Second.Visible = false;
            this.Winner_Second.Click += new System.EventHandler(this.Winner_Second_Click);
            // 
            // Gyors_btn
            // 
            this.Gyors_btn.Location = new System.Drawing.Point(45, 512);
            this.Gyors_btn.Name = "Gyors_btn";
            this.Gyors_btn.Size = new System.Drawing.Size(100, 23);
            this.Gyors_btn.TabIndex = 7;
            this.Gyors_btn.Text = "Gyorsítás";
            this.Gyors_btn.UseVisualStyleBackColor = true;
            this.Gyors_btn.Click += new System.EventHandler(this.Gyors_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(291, 542);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zarodoga.Properties.Resources.Jungle_Background;
            this.ClientSize = new System.Drawing.Size(447, 666);
            this.Controls.Add(this.Gyors_btn);
            this.Controls.Add(this.Winner_Second);
            this.Controls.Add(this.Winner_Third);
            this.Controls.Add(this.Winner_First);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.Start_Ingame);
            this.Controls.Add(this.Player_third_element);
            this.Controls.Add(this.Enemy_third_element);
            this.Controls.Add(this.Player_second_element);
            this.Controls.Add(this.Enemy_first_element);
            this.Controls.Add(this.Enemy_second_element);
            this.Controls.Add(this.Player_first_element);
            this.Controls.Add(this.Enemy_hp);
            this.Controls.Add(this.Player_hp);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InGame";
            this.Load += new System.EventHandler(this.InGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_first_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_second_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_third_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_second_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_first_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_third_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winner_First)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winner_Third)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Winner_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.ProgressBar Player_hp;
        private System.Windows.Forms.ProgressBar Enemy_hp;
        private System.Windows.Forms.PictureBox Player_first_element;
        private System.Windows.Forms.PictureBox Player_second_element;
        private System.Windows.Forms.PictureBox Player_third_element;
        private System.Windows.Forms.PictureBox Enemy_second_element;
        private System.Windows.Forms.PictureBox Enemy_first_element;
        private System.Windows.Forms.PictureBox Enemy_third_element;
        private System.Windows.Forms.Button Start_Ingame;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Timer Round;
        private System.Windows.Forms.PictureBox Winner_First;
        private System.Windows.Forms.PictureBox Winner_Third;
        private System.Windows.Forms.PictureBox Winner_Second;
        private System.Windows.Forms.Button Gyors_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}