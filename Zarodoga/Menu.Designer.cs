namespace Zarodoga
{
    partial class Basic
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
            this.Exit_Button_Btn = new System.Windows.Forms.Button();
            this.Options_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Player_infolbl = new System.Windows.Forms.Label();
            this.Szintbr = new System.Windows.Forms.ProgressBar();
            this.Tapasztalati_szintlbl = new System.Windows.Forms.Label();
            this.Aranylbl = new System.Windows.Forms.Label();
            this.Arany_button = new System.Windows.Forms.Button();
            this.vip_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_Button_Btn
            // 
            this.Exit_Button_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Button_Btn.Location = new System.Drawing.Point(230, 503);
            this.Exit_Button_Btn.Name = "Exit_Button_Btn";
            this.Exit_Button_Btn.Size = new System.Drawing.Size(165, 50);
            this.Exit_Button_Btn.TabIndex = 2;
            this.Exit_Button_Btn.Text = "Exit";
            this.Exit_Button_Btn.UseVisualStyleBackColor = true;
            this.Exit_Button_Btn.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Options_Button
            // 
            this.Options_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Options_Button.Location = new System.Drawing.Point(230, 382);
            this.Options_Button.Name = "Options_Button";
            this.Options_Button.Size = new System.Drawing.Size(165, 50);
            this.Options_Button.TabIndex = 1;
            this.Options_Button.Text = "Options";
            this.Options_Button.UseVisualStyleBackColor = true;
            this.Options_Button.Click += new System.EventHandler(this.Options_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start_Button.Location = new System.Drawing.Point(230, 261);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(165, 50);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Player_infolbl
            // 
            this.Player_infolbl.BackColor = System.Drawing.Color.LightGray;
            this.Player_infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player_infolbl.Location = new System.Drawing.Point(12, 9);
            this.Player_infolbl.Name = "Player_infolbl";
            this.Player_infolbl.Size = new System.Drawing.Size(220, 25);
            this.Player_infolbl.TabIndex = 2;
            this.Player_infolbl.Text = "Üdvözöllek: ";
            this.Player_infolbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Szintbr
            // 
            this.Szintbr.Location = new System.Drawing.Point(395, 40);
            this.Szintbr.Name = "Szintbr";
            this.Szintbr.Size = new System.Drawing.Size(220, 25);
            this.Szintbr.Step = 1;
            this.Szintbr.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Szintbr.TabIndex = 3;
            // 
            // Tapasztalati_szintlbl
            // 
            this.Tapasztalati_szintlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.Tapasztalati_szintlbl.Location = new System.Drawing.Point(395, 12);
            this.Tapasztalati_szintlbl.Name = "Tapasztalati_szintlbl";
            this.Tapasztalati_szintlbl.Size = new System.Drawing.Size(220, 25);
            this.Tapasztalati_szintlbl.TabIndex = 4;
            this.Tapasztalati_szintlbl.Text = "Tapasztalati szint: ";
            this.Tapasztalati_szintlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Aranylbl
            // 
            this.Aranylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.Aranylbl.Location = new System.Drawing.Point(13, 39);
            this.Aranylbl.Name = "Aranylbl";
            this.Aranylbl.Size = new System.Drawing.Size(220, 25);
            this.Aranylbl.TabIndex = 5;
            this.Aranylbl.Text = "Arany: ";
            this.Aranylbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Arany_button
            // 
            this.Arany_button.Enabled = false;
            this.Arany_button.Location = new System.Drawing.Point(13, 67);
            this.Arany_button.Name = "Arany_button";
            this.Arany_button.Size = new System.Drawing.Size(222, 25);
            this.Arany_button.TabIndex = 6;
            this.Arany_button.Text = "Feltöltés";
            this.Arany_button.UseVisualStyleBackColor = true;
            this.Arany_button.Visible = false;
            this.Arany_button.Click += new System.EventHandler(this.Arany_button_Click);
            // 
            // vip_btn
            // 
            this.vip_btn.Location = new System.Drawing.Point(393, 67);
            this.vip_btn.Name = "vip_btn";
            this.vip_btn.Size = new System.Drawing.Size(222, 25);
            this.vip_btn.TabIndex = 6;
            this.vip_btn.Text = "VIP tagság";
            this.vip_btn.UseVisualStyleBackColor = true;
            this.vip_btn.Click += new System.EventHandler(this.Vip_btn_Click);
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zarodoga.Properties.Resources.Alchemy_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 608);
            this.Controls.Add(this.vip_btn);
            this.Controls.Add(this.Arany_button);
            this.Controls.Add(this.Aranylbl);
            this.Controls.Add(this.Tapasztalati_szintlbl);
            this.Controls.Add(this.Szintbr);
            this.Controls.Add(this.Player_infolbl);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Options_Button);
            this.Controls.Add(this.Exit_Button_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Basic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Basic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button_Btn;
        private System.Windows.Forms.Button Options_Button;
        private System.Windows.Forms.Button Start_Button;
        public System.Windows.Forms.Label Player_infolbl;
        public System.Windows.Forms.ProgressBar Szintbr;
        private System.Windows.Forms.Label Tapasztalati_szintlbl;
        public System.Windows.Forms.Label Aranylbl;
        private System.Windows.Forms.Button Arany_button;
        private System.Windows.Forms.Button vip_btn;
    }
}