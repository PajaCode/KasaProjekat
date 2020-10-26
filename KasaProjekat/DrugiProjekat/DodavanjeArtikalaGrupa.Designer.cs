namespace DrugiProjekat
{
    partial class DodavanjeArtikalaGrupa
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
            this.PregledBtn = new System.Windows.Forms.Button();
            this.DodajArtikalBtn = new System.Windows.Forms.Button();
            this.LSBgrupa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PregledBtn
            // 
            this.PregledBtn.Enabled = false;
            this.PregledBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledBtn.Location = new System.Drawing.Point(252, 245);
            this.PregledBtn.Name = "PregledBtn";
            this.PregledBtn.Size = new System.Drawing.Size(98, 43);
            this.PregledBtn.TabIndex = 5;
            this.PregledBtn.Text = "PRIKAZI";
            this.PregledBtn.UseVisualStyleBackColor = true;
            this.PregledBtn.Click += new System.EventHandler(this.PregledBtn_Click_1);
            // 
            // DodajArtikalBtn
            // 
            this.DodajArtikalBtn.Enabled = false;
            this.DodajArtikalBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajArtikalBtn.Location = new System.Drawing.Point(102, 245);
            this.DodajArtikalBtn.Name = "DodajArtikalBtn";
            this.DodajArtikalBtn.Size = new System.Drawing.Size(98, 43);
            this.DodajArtikalBtn.TabIndex = 4;
            this.DodajArtikalBtn.Text = "DODAJ";
            this.DodajArtikalBtn.UseVisualStyleBackColor = true;
            this.DodajArtikalBtn.Click += new System.EventHandler(this.DodajArtikalBtn_Click_1);
            // 
            // LSBgrupa
            // 
            this.LSBgrupa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSBgrupa.FormattingEnabled = true;
            this.LSBgrupa.ItemHeight = 16;
            this.LSBgrupa.Location = new System.Drawing.Point(40, 38);
            this.LSBgrupa.Name = "LSBgrupa";
            this.LSBgrupa.ScrollAlwaysVisible = true;
            this.LSBgrupa.Size = new System.Drawing.Size(402, 180);
            this.LSBgrupa.TabIndex = 3;
            // 
            // DodavanjeArtikalaGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(478, 305);
            this.Controls.Add(this.PregledBtn);
            this.Controls.Add(this.DodajArtikalBtn);
            this.Controls.Add(this.LSBgrupa);
            this.Name = "DodavanjeArtikalaGrupa";
            this.Text = "DodavanjeArtikalaGrupa";
            this.Load += new System.EventHandler(this.DodavanjeArtikalaGrupa_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PregledBtn;
        private System.Windows.Forms.Button DodajArtikalBtn;
        private System.Windows.Forms.ListBox LSBgrupa;
    }
}