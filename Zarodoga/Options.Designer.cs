namespace Zarodoga
{
    partial class Options
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
            this.Felhasznalo_lbl = new System.Windows.Forms.Label();
            this.Felhasznalo_box = new System.Windows.Forms.TextBox();
            this.info_lbl = new System.Windows.Forms.Label();
            this.info2_lbl = new System.Windows.Forms.Label();
            this.Elsojelszo_box = new System.Windows.Forms.TextBox();
            this.Masodikjelszo_box = new System.Windows.Forms.TextBox();
            this.ujra_lbl = new System.Windows.Forms.Label();
            this.Felhasznalo_btn = new System.Windows.Forms.Button();
            this.Jelszo_btn = new System.Windows.Forms.Button();
            this.Vissza_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Felhasznalo_lbl
            // 
            this.Felhasznalo_lbl.Location = new System.Drawing.Point(68, 9);
            this.Felhasznalo_lbl.Name = "Felhasznalo_lbl";
            this.Felhasznalo_lbl.Size = new System.Drawing.Size(227, 23);
            this.Felhasznalo_lbl.TabIndex = 0;
            this.Felhasznalo_lbl.Text = "Felhasznaló neve: ";
            this.Felhasznalo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Felhasznalo_box
            // 
            this.Felhasznalo_box.Location = new System.Drawing.Point(71, 78);
            this.Felhasznalo_box.Name = "Felhasznalo_box";
            this.Felhasznalo_box.Size = new System.Drawing.Size(224, 20);
            this.Felhasznalo_box.TabIndex = 0;
            // 
            // info_lbl
            // 
            this.info_lbl.Location = new System.Drawing.Point(68, 52);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(227, 23);
            this.info_lbl.TabIndex = 2;
            this.info_lbl.Text = "Adja meg az új felhasználónevét";
            this.info_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info2_lbl
            // 
            this.info2_lbl.Location = new System.Drawing.Point(68, 146);
            this.info2_lbl.Name = "info2_lbl";
            this.info2_lbl.Size = new System.Drawing.Size(227, 23);
            this.info2_lbl.TabIndex = 3;
            this.info2_lbl.Text = "Adja meg az új jelszavát";
            this.info2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Elsojelszo_box
            // 
            this.Elsojelszo_box.Location = new System.Drawing.Point(71, 172);
            this.Elsojelszo_box.Name = "Elsojelszo_box";
            this.Elsojelszo_box.PasswordChar = '*';
            this.Elsojelszo_box.Size = new System.Drawing.Size(224, 20);
            this.Elsojelszo_box.TabIndex = 2;
            // 
            // Masodikjelszo_box
            // 
            this.Masodikjelszo_box.Location = new System.Drawing.Point(71, 237);
            this.Masodikjelszo_box.Name = "Masodikjelszo_box";
            this.Masodikjelszo_box.PasswordChar = '*';
            this.Masodikjelszo_box.Size = new System.Drawing.Size(224, 20);
            this.Masodikjelszo_box.TabIndex = 3;
            // 
            // ujra_lbl
            // 
            this.ujra_lbl.Location = new System.Drawing.Point(68, 211);
            this.ujra_lbl.Name = "ujra_lbl";
            this.ujra_lbl.Size = new System.Drawing.Size(227, 23);
            this.ujra_lbl.TabIndex = 3;
            this.ujra_lbl.Text = "Adja meg az új jelszavát mégegyszer";
            this.ujra_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Felhasznalo_btn
            // 
            this.Felhasznalo_btn.Location = new System.Drawing.Point(71, 104);
            this.Felhasznalo_btn.Name = "Felhasznalo_btn";
            this.Felhasznalo_btn.Size = new System.Drawing.Size(224, 23);
            this.Felhasznalo_btn.TabIndex = 1;
            this.Felhasznalo_btn.Text = "Felhasznaló mentése";
            this.Felhasznalo_btn.UseVisualStyleBackColor = true;
            this.Felhasznalo_btn.Click += new System.EventHandler(this.Felhasznalo_btn_Click);
            // 
            // Jelszo_btn
            // 
            this.Jelszo_btn.Location = new System.Drawing.Point(71, 263);
            this.Jelszo_btn.Name = "Jelszo_btn";
            this.Jelszo_btn.Size = new System.Drawing.Size(224, 23);
            this.Jelszo_btn.TabIndex = 4;
            this.Jelszo_btn.Text = "Jelszó mentése";
            this.Jelszo_btn.UseVisualStyleBackColor = true;
            this.Jelszo_btn.Click += new System.EventHandler(this.Jelszo_btn_Click);
            // 
            // Vissza_btn
            // 
            this.Vissza_btn.Location = new System.Drawing.Point(71, 379);
            this.Vissza_btn.Name = "Vissza_btn";
            this.Vissza_btn.Size = new System.Drawing.Size(224, 23);
            this.Vissza_btn.TabIndex = 5;
            this.Vissza_btn.Text = "Vissza";
            this.Vissza_btn.UseVisualStyleBackColor = true;
            this.Vissza_btn.Click += new System.EventHandler(this.Vissza_btn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 414);
            this.Controls.Add(this.Vissza_btn);
            this.Controls.Add(this.Jelszo_btn);
            this.Controls.Add(this.Felhasznalo_btn);
            this.Controls.Add(this.ujra_lbl);
            this.Controls.Add(this.info2_lbl);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.Masodikjelszo_box);
            this.Controls.Add(this.Elsojelszo_box);
            this.Controls.Add(this.Felhasznalo_box);
            this.Controls.Add(this.Felhasznalo_lbl);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Felhasznalo_lbl;
        private System.Windows.Forms.TextBox Felhasznalo_box;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Label info2_lbl;
        private System.Windows.Forms.TextBox Elsojelszo_box;
        private System.Windows.Forms.TextBox Masodikjelszo_box;
        private System.Windows.Forms.Label ujra_lbl;
        private System.Windows.Forms.Button Felhasznalo_btn;
        private System.Windows.Forms.Button Jelszo_btn;
        private System.Windows.Forms.Button Vissza_btn;
    }
}