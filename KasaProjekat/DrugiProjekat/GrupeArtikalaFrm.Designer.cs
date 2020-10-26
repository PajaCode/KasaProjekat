namespace DrugiProjekat
{
    partial class GrupeArtikalaFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.LSBArtikal = new System.Windows.Forms.ListBox();
            this.LSBGrupa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "SACUVAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dodaj
            // 
            this.Dodaj.Enabled = false;
            this.Dodaj.Location = new System.Drawing.Point(347, 18);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(92, 41);
            this.Dodaj.TabIndex = 8;
            this.Dodaj.Text = "DODAJ";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click_1);
            // 
            // LSBArtikal
            // 
            this.LSBArtikal.FormattingEnabled = true;
            this.LSBArtikal.Location = new System.Drawing.Point(36, 131);
            this.LSBArtikal.Name = "LSBArtikal";
            this.LSBArtikal.Size = new System.Drawing.Size(448, 147);
            this.LSBArtikal.TabIndex = 7;
            // 
            // LSBGrupa
            // 
            this.LSBGrupa.FormattingEnabled = true;
            this.LSBGrupa.Location = new System.Drawing.Point(36, 18);
            this.LSBGrupa.Name = "LSBGrupa";
            this.LSBGrupa.Size = new System.Drawing.Size(281, 82);
            this.LSBGrupa.TabIndex = 6;
            this.LSBGrupa.SelectedIndexChanged += new System.EventHandler(this.LSBGrupa_SelectedIndexChanged);
            // 
            // GrupeArtikalaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(511, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.LSBArtikal);
            this.Controls.Add(this.LSBGrupa);
            this.Name = "GrupeArtikalaFrm";
            this.Text = "GrupeArtikalaFrm";
            this.Load += new System.EventHandler(this.GrupeArtikalaFrm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.ListBox LSBArtikal;
        private System.Windows.Forms.ListBox LSBGrupa;
    }
}