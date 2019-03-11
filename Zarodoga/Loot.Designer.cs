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
            this.SuspendLayout();
            // 
            // Loot_label
            // 
            this.Loot_label.Location = new System.Drawing.Point(94, 61);
            this.Loot_label.Name = "Loot_label";
            this.Loot_label.Size = new System.Drawing.Size(165, 53);
            this.Loot_label.TabIndex = 0;
            // 
            // Loot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 313);
            this.Controls.Add(this.Loot_label);
            this.Name = "Loot";
            this.Text = "Loot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Loot_label;
    }
}