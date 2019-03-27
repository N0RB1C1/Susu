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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Options_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Continue_Button = new System.Windows.Forms.Button();
            this.Player_info = new System.Windows.Forms.Label();
            this.Szint = new System.Windows.Forms.ProgressBar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Arany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Button.Location = new System.Drawing.Point(230, 503);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(165, 50);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
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
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start_Button.Location = new System.Drawing.Point(230, 261);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(165, 50);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Continue_Button
            // 
            this.Continue_Button.Enabled = false;
            this.Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Continue_Button.Location = new System.Drawing.Point(230, 145);
            this.Continue_Button.Name = "Continue_Button";
            this.Continue_Button.Size = new System.Drawing.Size(165, 50);
            this.Continue_Button.TabIndex = 1;
            this.Continue_Button.Text = "Continue";
            this.Continue_Button.UseVisualStyleBackColor = true;
            this.Continue_Button.Visible = false;
            // 
            // Player_info
            // 
            this.Player_info.BackColor = System.Drawing.Color.LightGray;
            this.Player_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player_info.Location = new System.Drawing.Point(12, 9);
            this.Player_info.Name = "Player_info";
            this.Player_info.Size = new System.Drawing.Size(212, 26);
            this.Player_info.TabIndex = 2;
            this.Player_info.Text = "Üdvözöllek: ";
            this.Player_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Szint
            // 
            this.Szint.Location = new System.Drawing.Point(401, 39);
            this.Szint.Name = "Szint";
            this.Szint.Size = new System.Drawing.Size(214, 23);
            this.Szint.Step = 1;
            this.Szint.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Szint.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(401, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(214, 23);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Tapasztalati szint: ";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Arany
            // 
            this.Arany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(238)));
            this.Arany.Location = new System.Drawing.Point(13, 39);
            this.Arany.Name = "Arany";
            this.Arany.Size = new System.Drawing.Size(211, 23);
            this.Arany.TabIndex = 5;
            this.Arany.Text = "Arany: ";
            this.Arany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zarodoga.Properties.Resources.Alchemy_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 608);
            this.Controls.Add(this.Arany);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.Szint);
            this.Controls.Add(this.Player_info);
            this.Controls.Add(this.Continue_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Options_Button);
            this.Controls.Add(this.Exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Basic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Basic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Options_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Continue_Button;
        public System.Windows.Forms.Label Player_info;
        public System.Windows.Forms.ProgressBar Szint;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label Arany;
    }
}