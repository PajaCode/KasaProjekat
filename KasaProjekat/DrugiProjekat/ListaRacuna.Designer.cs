namespace DrugiProjekat
{
    partial class ListaRacuna
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
            this.LSBRacuna = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LSBRacuna
            // 
            this.LSBRacuna.FormattingEnabled = true;
            this.LSBRacuna.Location = new System.Drawing.Point(99, 12);
            this.LSBRacuna.Name = "LSBRacuna";
            this.LSBRacuna.ScrollAlwaysVisible = true;
            this.LSBRacuna.Size = new System.Drawing.Size(388, 238);
            this.LSBRacuna.TabIndex = 1;
            // 
            // ListaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 356);
            this.Controls.Add(this.LSBRacuna);
            this.Name = "ListaRacuna";
            this.Text = "ListaRacuna";
            this.Load += new System.EventHandler(this.ListaRacuna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LSBRacuna;
    }
}