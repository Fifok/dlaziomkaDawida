namespace ZestawieniePracownikow
{
    partial class Form1
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
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.lblZarobki = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbStanowisko = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.numZarobki = new System.Windows.Forms.NumericUpDown();
            this.btnOblicz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numZarobki)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(68, 15);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(26, 13);
            this.lblImie.TabIndex = 0;
            this.lblImie.Text = "Imie";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(170, 15);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(53, 13);
            this.lblNazwisko.TabIndex = 1;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Location = new System.Drawing.Point(290, 15);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(62, 13);
            this.lblStanowisko.TabIndex = 2;
            this.lblStanowisko.Text = "Stanowisko";
            // 
            // lblZarobki
            // 
            this.lblZarobki.AutoSize = true;
            this.lblZarobki.Location = new System.Drawing.Point(425, 15);
            this.lblZarobki.Name = "lblZarobki";
            this.lblZarobki.Size = new System.Drawing.Size(43, 13);
            this.lblZarobki.TabIndex = 3;
            this.lblZarobki.Text = "Zarobki";
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(31, 34);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 20);
            this.tbImie.TabIndex = 4;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(146, 34);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tbNazwisko.TabIndex = 5;
            // 
            // tbStanowisko
            // 
            this.tbStanowisko.Location = new System.Drawing.Point(252, 34);
            this.tbStanowisko.Name = "tbStanowisko";
            this.tbStanowisko.Size = new System.Drawing.Size(138, 20);
            this.tbStanowisko.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(517, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // numZarobki
            // 
            this.numZarobki.Location = new System.Drawing.Point(405, 34);
            this.numZarobki.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numZarobki.Name = "numZarobki";
            this.numZarobki.Size = new System.Drawing.Size(91, 20);
            this.numZarobki.TabIndex = 10;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(620, 31);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 11;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 80);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.numZarobki);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbStanowisko);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.lblZarobki);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numZarobki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.Label lblZarobki;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbStanowisko;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown numZarobki;
        private System.Windows.Forms.Button btnOblicz;
    }
}

