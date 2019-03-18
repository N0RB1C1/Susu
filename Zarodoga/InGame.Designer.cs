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
            this.Enemy_Label = new System.Windows.Forms.Label();
            this.Start_Ingame = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.Round = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_first_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_second_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_third_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_second_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_first_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_third_element)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Location = new System.Drawing.Point(169, 476);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 113);
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
            this.Player_hp.Location = new System.Drawing.Point(169, 450);
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
            this.Player_first_element.Location = new System.Drawing.Point(45, 299);
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
            this.Player_second_element.Location = new System.Drawing.Point(169, 299);
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
            this.Player_third_element.Location = new System.Drawing.Point(291, 299);
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
            this.Enemy_second_element.Location = new System.Drawing.Point(169, 159);
            this.Enemy_second_element.Name = "Enemy_second_element";
            this.Enemy_second_element.Size = new System.Drawing.Size(100, 100);
            this.Enemy_second_element.TabIndex = 2;
            this.Enemy_second_element.TabStop = false;
            // 
            // Enemy_first_element
            // 
            this.Enemy_first_element.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_first_element.Location = new System.Drawing.Point(45, 159);
            this.Enemy_first_element.Name = "Enemy_first_element";
            this.Enemy_first_element.Size = new System.Drawing.Size(100, 100);
            this.Enemy_first_element.TabIndex = 2;
            this.Enemy_first_element.TabStop = false;
            // 
            // Enemy_third_element
            // 
            this.Enemy_third_element.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_third_element.Location = new System.Drawing.Point(291, 159);
            this.Enemy_third_element.Name = "Enemy_third_element";
            this.Enemy_third_element.Size = new System.Drawing.Size(100, 100);
            this.Enemy_third_element.TabIndex = 2;
            this.Enemy_third_element.TabStop = false;
            // 
            // Enemy_Label
            // 
            this.Enemy_Label.BackColor = System.Drawing.Color.Transparent;
            this.Enemy_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Enemy_Label.Location = new System.Drawing.Point(275, 12);
            this.Enemy_Label.Name = "Enemy_Label";
            this.Enemy_Label.Size = new System.Drawing.Size(116, 115);
            this.Enemy_Label.TabIndex = 3;
            this.Enemy_Label.Text = "Enemy";
            // 
            // Start_Ingame
            // 
            this.Start_Ingame.Location = new System.Drawing.Point(169, 270);
            this.Start_Ingame.Name = "Start_Ingame";
            this.Start_Ingame.Size = new System.Drawing.Size(100, 23);
            this.Start_Ingame.TabIndex = 4;
            this.Start_Ingame.Text = "Start";
            this.Start_Ingame.UseVisualStyleBackColor = true;
            this.Start_Ingame.Click += new System.EventHandler(this.Start_Ingame_Click);
            // 
            // info_label
            // 
            this.info_label.Location = new System.Drawing.Point(288, 476);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(103, 83);
            this.info_label.TabIndex = 5;
            // 
            // Round
            // 
            this.Round.Tick += new System.EventHandler(this.Round_Tick);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zarodoga.Properties.Resources.Jungle_Background;
            this.ClientSize = new System.Drawing.Size(445, 601);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.Start_Ingame);
            this.Controls.Add(this.Enemy_Label);
            this.Controls.Add(this.Player_third_element);
            this.Controls.Add(this.Enemy_third_element);
            this.Controls.Add(this.Player_second_element);
            this.Controls.Add(this.Enemy_first_element);
            this.Controls.Add(this.Enemy_second_element);
            this.Controls.Add(this.Player_first_element);
            this.Controls.Add(this.Enemy_hp);
            this.Controls.Add(this.Player_hp);
            this.Controls.Add(this.Enemy);
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
        private System.Windows.Forms.Label Enemy_Label;
        private System.Windows.Forms.Button Start_Ingame;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Timer Round;
    }
}