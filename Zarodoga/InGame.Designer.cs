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
            this.Player.Location = new System.Drawing.Point(169, 441);
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
            this.Player_hp.Location = new System.Drawing.Point(169, 415);
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
            this.Player_first_element.BackColor = System.Drawing.Color.Transparent;
            this.Player_first_element.Location = new System.Drawing.Point(45, 310);
            this.Player_first_element.Name = "Player_first_element";
            this.Player_first_element.Size = new System.Drawing.Size(100, 100);
            this.Player_first_element.TabIndex = 2;
            this.Player_first_element.TabStop = false;
            this.Player_first_element.Click += new System.EventHandler(this.Player_first_element_Click);
            // 
            // Player_second_element
            // 
            this.Player_second_element.BackColor = System.Drawing.Color.Transparent;
            this.Player_second_element.Location = new System.Drawing.Point(169, 310);
            this.Player_second_element.Name = "Player_second_element";
            this.Player_second_element.Size = new System.Drawing.Size(100, 100);
            this.Player_second_element.TabIndex = 2;
            this.Player_second_element.TabStop = false;
            // 
            // Player_third_element
            // 
            this.Player_third_element.BackColor = System.Drawing.Color.Transparent;
            this.Player_third_element.Location = new System.Drawing.Point(291, 310);
            this.Player_third_element.Name = "Player_third_element";
            this.Player_third_element.Padding = new System.Windows.Forms.Padding(3);
            this.Player_third_element.Size = new System.Drawing.Size(100, 100);
            this.Player_third_element.TabIndex = 2;
            this.Player_third_element.TabStop = false;
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
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zarodoga.Properties.Resources.Jungle_Background;
            this.ClientSize = new System.Drawing.Size(445, 566);
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
            this.Text = "InGame";
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
    }
}