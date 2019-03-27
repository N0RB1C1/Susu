namespace Zarodoga
{
    partial class Loot
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
            this.Loot_label = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.Pick_up_loot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loot_label
            // 
            this.Loot_label.Location = new System.Drawing.Point(94, 156);
            this.Loot_label.Name = "Loot_label";
            this.Loot_label.Size = new System.Drawing.Size(173, 53);
            this.Loot_label.TabIndex = 0;
            // 
            // End
            // 
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.End.Location = new System.Drawing.Point(94, 49);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(173, 83);
            this.End.TabIndex = 1;
            this.End.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pick_up_loot
            // 
            this.Pick_up_loot.Location = new System.Drawing.Point(97, 212);
            this.Pick_up_loot.Name = "Pick_up_loot";
            this.Pick_up_loot.Size = new System.Drawing.Size(170, 23);
            this.Pick_up_loot.TabIndex = 2;
            this.Pick_up_loot.Text = "Rendben ";
            this.Pick_up_loot.UseVisualStyleBackColor = true;
            this.Pick_up_loot.Click += new System.EventHandler(this.Pick_up_loot_Click);
            // 
            // Loot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 313);
            this.Controls.Add(this.Pick_up_loot);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Loot_label);
            this.Name = "Loot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loot";
            this.Load += new System.EventHandler(this.Loot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Loot_label;
        public System.Windows.Forms.Label End;
        private System.Windows.Forms.Button Pick_up_loot;
    }
}