namespace SistemPrevoz
{
    partial class Admin_forma
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
            this.btnPutnik = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnRezervacija_po_turi = new System.Windows.Forms.Button();
            this.btnVozac_po_turi = new System.Windows.Forms.Button();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.btnVozilo = new System.Windows.Forms.Button();
            this.btnVozac = new System.Windows.Forms.Button();
            this.btnTura = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPolasci = new System.Windows.Forms.Button();
            this.btnIzloguj = new System.Windows.Forms.Button();
            this.korisniciTableAdapter1 = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.korisniciTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPutnik
            // 
            this.btnPutnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPutnik.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPutnik.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnPutnik.Location = new System.Drawing.Point(27, 129);
            this.btnPutnik.Name = "btnPutnik";
            this.btnPutnik.Size = new System.Drawing.Size(157, 57);
            this.btnPutnik.TabIndex = 25;
            this.btnPutnik.Text = "Putnici";
            this.btnPutnik.UseVisualStyleBackColor = true;
            this.btnPutnik.Click += new System.EventHandler(this.btnPutnik_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzlaz.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnIzlaz.Location = new System.Drawing.Point(142, 390);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(129, 57);
            this.btnIzlaz.TabIndex = 24;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnRezervacija_po_turi
            // 
            this.btnRezervacija_po_turi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervacija_po_turi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRezervacija_po_turi.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnRezervacija_po_turi.Location = new System.Drawing.Point(27, 216);
            this.btnRezervacija_po_turi.Name = "btnRezervacija_po_turi";
            this.btnRezervacija_po_turi.Size = new System.Drawing.Size(157, 57);
            this.btnRezervacija_po_turi.TabIndex = 23;
            this.btnRezervacija_po_turi.Text = "Putnik-tura";
            this.btnRezervacija_po_turi.UseVisualStyleBackColor = true;
            this.btnRezervacija_po_turi.Click += new System.EventHandler(this.btnRezervacija_po_turi_Click);
            // 
            // btnVozac_po_turi
            // 
            this.btnVozac_po_turi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVozac_po_turi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVozac_po_turi.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnVozac_po_turi.Location = new System.Drawing.Point(27, 302);
            this.btnVozac_po_turi.Name = "btnVozac_po_turi";
            this.btnVozac_po_turi.Size = new System.Drawing.Size(157, 57);
            this.btnVozac_po_turi.TabIndex = 22;
            this.btnVozac_po_turi.Text = "Vozac-tura";
            this.btnVozac_po_turi.UseVisualStyleBackColor = true;
            this.btnVozac_po_turi.Click += new System.EventHandler(this.btnVozac_po_turi_Click);
            // 
            // btnLokacija
            // 
            this.btnLokacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLokacija.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLokacija.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnLokacija.Location = new System.Drawing.Point(30, 303);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(157, 57);
            this.btnLokacija.TabIndex = 20;
            this.btnLokacija.Text = "Destinacija";
            this.btnLokacija.UseVisualStyleBackColor = true;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // btnVozilo
            // 
            this.btnVozilo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVozilo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVozilo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnVozilo.Location = new System.Drawing.Point(30, 217);
            this.btnVozilo.Name = "btnVozilo";
            this.btnVozilo.Size = new System.Drawing.Size(157, 57);
            this.btnVozilo.TabIndex = 19;
            this.btnVozilo.Text = "Vozila";
            this.btnVozilo.UseVisualStyleBackColor = true;
            this.btnVozilo.Click += new System.EventHandler(this.btnVozilo_Click);
            // 
            // btnVozac
            // 
            this.btnVozac.BackColor = System.Drawing.Color.White;
            this.btnVozac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVozac.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVozac.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnVozac.Location = new System.Drawing.Point(30, 130);
            this.btnVozac.Name = "btnVozac";
            this.btnVozac.Size = new System.Drawing.Size(157, 57);
            this.btnVozac.TabIndex = 18;
            this.btnVozac.Text = "Vozaci";
            this.btnVozac.UseVisualStyleBackColor = true;
            this.btnVozac.Click += new System.EventHandler(this.btnVozac_Click);
            // 
            // btnTura
            // 
            this.btnTura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTura.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTura.Location = new System.Drawing.Point(30, 42);
            this.btnTura.Name = "btnTura";
            this.btnTura.Size = new System.Drawing.Size(157, 57);
            this.btnTura.TabIndex = 17;
            this.btnTura.Text = "Tura";
            this.btnTura.UseVisualStyleBackColor = true;
            this.btnTura.Click += new System.EventHandler(this.btnTura_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnTura);
            this.panel1.Controls.Add(this.btnVozac);
            this.panel1.Controls.Add(this.btnVozilo);
            this.panel1.Controls.Add(this.btnLokacija);
            this.panel1.Location = new System.Drawing.Point(13, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 419);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 631);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(35, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 577);
            this.panel3.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnRezervacija);
            this.panel5.Controls.Add(this.btnPutnik);
            this.panel5.Controls.Add(this.btnRezervacija_po_turi);
            this.panel5.Controls.Add(this.btnVozac_po_turi);
            this.panel5.Location = new System.Drawing.Point(959, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 419);
            this.panel5.TabIndex = 21;
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervacija.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRezervacija.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnRezervacija.Location = new System.Drawing.Point(27, 41);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(157, 57);
            this.btnRezervacija.TabIndex = 27;
            this.btnRezervacija.Text = "Rezervacije";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btnKorisnici);
            this.panel4.Controls.Add(this.btnPolasci);
            this.panel4.Controls.Add(this.btnIzloguj);
            this.panel4.Controls.Add(this.btnIzlaz);
            this.panel4.Location = new System.Drawing.Point(252, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 534);
            this.panel4.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.Naslov);
            this.panel6.Location = new System.Drawing.Point(21, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(641, 100);
            this.panel6.TabIndex = 27;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(3, 32);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(631, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Transport Menadzment Sistem";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnKorisnici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKorisnici.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnKorisnici.Location = new System.Drawing.Point(271, 274);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(129, 57);
            this.btnKorisnici.TabIndex = 28;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnPolasci
            // 
            this.btnPolasci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPolasci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPolasci.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPolasci.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnPolasci.Location = new System.Drawing.Point(254, 159);
            this.btnPolasci.Name = "btnPolasci";
            this.btnPolasci.Size = new System.Drawing.Size(157, 57);
            this.btnPolasci.TabIndex = 26;
            this.btnPolasci.Text = "Polasci";
            this.btnPolasci.UseVisualStyleBackColor = true;
            this.btnPolasci.Click += new System.EventHandler(this.btnPolasci_Click);
            // 
            // btnIzloguj
            // 
            this.btnIzloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIzloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzloguj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzloguj.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.btnIzloguj.Location = new System.Drawing.Point(405, 390);
            this.btnIzloguj.Name = "btnIzloguj";
            this.btnIzloguj.Size = new System.Drawing.Size(129, 57);
            this.btnIzloguj.TabIndex = 25;
            this.btnIzloguj.Text = "Izloguj se";
            this.btnIzloguj.UseVisualStyleBackColor = true;
            this.btnIzloguj.Click += new System.EventHandler(this.btnIzloguj_Click);
            // 
            // korisniciTableAdapter1
            // 
            this.korisniciTableAdapter1.ClearBeforeFill = true;
            // 
            // Admin_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 622);
            this.Controls.Add(this.panel2);
            this.Name = "Admin_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPutnik;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnRezervacija_po_turi;
        private System.Windows.Forms.Button btnVozac_po_turi;
        private System.Windows.Forms.Button btnLokacija;
        private System.Windows.Forms.Button btnVozilo;
        private System.Windows.Forms.Button btnVozac;
        private System.Windows.Forms.Button btnTura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnIzloguj;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Button btnPolasci;
        private transport_menadzmentDataSetTableAdapters.korisniciTableAdapter korisniciTableAdapter1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnRezervacija;
    }
}