namespace SistemPrevoz
{
    partial class Korisnici_forma
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label korisnik_idLabel;
            System.Windows.Forms.Label korisnikLabel;
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label nivoLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.nivoComboBox = new System.Windows.Forms.ComboBox();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.korisnik_idTextBox = new System.Windows.Forms.TextBox();
            this.korisnikTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnNapred = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.korisniciTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.korisniciTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            korisnik_idLabel = new System.Windows.Forms.Label();
            korisnikLabel = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            nivoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // korisnik_idLabel
            // 
            korisnik_idLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            korisnik_idLabel.AutoSize = true;
            korisnik_idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            korisnik_idLabel.ForeColor = System.Drawing.SystemColors.Info;
            korisnik_idLabel.Location = new System.Drawing.Point(3, 8);
            korisnik_idLabel.Name = "korisnik_idLabel";
            korisnik_idLabel.Size = new System.Drawing.Size(89, 19);
            korisnik_idLabel.TabIndex = 30;
            korisnik_idLabel.Text = "korisnik id:";
            // 
            // korisnikLabel
            // 
            korisnikLabel.AutoSize = true;
            korisnikLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            korisnikLabel.ForeColor = System.Drawing.SystemColors.Info;
            korisnikLabel.Location = new System.Drawing.Point(13, 10);
            korisnikLabel.Name = "korisnikLabel";
            korisnikLabel.Size = new System.Drawing.Size(70, 19);
            korisnikLabel.TabIndex = 32;
            korisnikLabel.Text = "korisnik:";
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            lozinkaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            lozinkaLabel.ForeColor = System.Drawing.SystemColors.Info;
            lozinkaLabel.Location = new System.Drawing.Point(13, 9);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(68, 19);
            lozinkaLabel.TabIndex = 34;
            lozinkaLabel.Text = "lozinka:";
            // 
            // nivoLabel
            // 
            nivoLabel.AutoSize = true;
            nivoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            nivoLabel.ForeColor = System.Drawing.SystemColors.Info;
            nivoLabel.Location = new System.Drawing.Point(23, 8);
            nivoLabel.Name = "nivoLabel";
            nivoLabel.Size = new System.Drawing.Size(46, 19);
            nivoLabel.TabIndex = 35;
            nivoLabel.Text = "nivo:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nivoComboBox);
            this.panel1.Controls.Add(this.korisnik_idTextBox);
            this.panel1.Controls.Add(this.korisnikTextBox);
            this.panel1.Controls.Add(this.lozinkaTextBox);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 636);
            this.panel1.TabIndex = 3;
            // 
            // nivoComboBox
            // 
            this.nivoComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisniciBindingSource, "nivo", true));
            this.nivoComboBox.FormattingEnabled = true;
            this.nivoComboBox.Items.AddRange(new object[] {
            "Admin",
            "Korisnik"});
            this.nivoComboBox.Location = new System.Drawing.Point(142, 297);
            this.nivoComboBox.Name = "nivoComboBox";
            this.nivoComboBox.Size = new System.Drawing.Size(121, 21);
            this.nivoComboBox.TabIndex = 36;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "korisnici";
            this.korisniciBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // transport_menadzmentDataSet
            // 
            this.transport_menadzmentDataSet.DataSetName = "transport_menadzmentDataSet";
            this.transport_menadzmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnik_idTextBox
            // 
            this.korisnik_idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.korisnik_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisniciBindingSource, "korisnik_id", true));
            this.korisnik_idTextBox.Location = new System.Drawing.Point(152, 131);
            this.korisnik_idTextBox.Name = "korisnik_idTextBox";
            this.korisnik_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnik_idTextBox.TabIndex = 31;
            // 
            // korisnikTextBox
            // 
            this.korisnikTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.korisnikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisniciBindingSource, "korisnik", true));
            this.korisnikTextBox.Location = new System.Drawing.Point(152, 188);
            this.korisnikTextBox.Name = "korisnikTextBox";
            this.korisnikTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnikTextBox.TabIndex = 33;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lozinkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisniciBindingSource, "lozinka", true));
            this.lozinkaTextBox.Location = new System.Drawing.Point(152, 243);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.lozinkaTextBox.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(korisnik_idLabel);
            this.panel7.Location = new System.Drawing.Point(21, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 39);
            this.panel7.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.Naslov);
            this.panel8.Location = new System.Drawing.Point(93, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(376, 89);
            this.panel8.TabIndex = 29;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Naslov.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(87, 20);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(199, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Korisnici";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(lozinkaLabel);
            this.panel6.Location = new System.Drawing.Point(21, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(97, 39);
            this.panel6.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnIzlaz);
            this.panel3.Controls.Add(this.btnSacuvaj);
            this.panel3.Controls.Add(this.btnNapred);
            this.panel3.Controls.Add(this.btnNazad);
            this.panel3.Controls.Add(this.btnIzbrisi);
            this.panel3.Controls.Add(this.btnDodaj);
            this.panel3.Location = new System.Drawing.Point(278, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 207);
            this.panel3.TabIndex = 8;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzlaz.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnIzlaz.Location = new System.Drawing.Point(131, 149);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(85, 34);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSacuvaj.Location = new System.Drawing.Point(21, 149);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(85, 34);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnNapred
            // 
            this.btnNapred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNapred.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNapred.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNapred.Location = new System.Drawing.Point(21, 82);
            this.btnNapred.Name = "btnNapred";
            this.btnNapred.Size = new System.Drawing.Size(85, 34);
            this.btnNapred.TabIndex = 3;
            this.btnNapred.Text = "Napred";
            this.btnNapred.UseVisualStyleBackColor = true;
            this.btnNapred.Click += new System.EventHandler(this.btnNapred_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNazad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNazad.Location = new System.Drawing.Point(131, 82);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(85, 34);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzbrisi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnIzbrisi.Location = new System.Drawing.Point(131, 16);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(85, 34);
            this.btnIzbrisi.TabIndex = 1;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.Location = new System.Drawing.Point(21, 16);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 34);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.korisniciDataGridView);
            this.panel2.Location = new System.Drawing.Point(32, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 261);
            this.panel2.TabIndex = 7;
            // 
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.AllowUserToAddRows = false;
            this.korisniciDataGridView.AllowUserToDeleteRows = false;
            this.korisniciDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.korisniciDataGridView.AutoGenerateColumns = false;
            this.korisniciDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.korisniciDataGridView.DataSource = this.korisniciBindingSource;
            this.korisniciDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.korisniciDataGridView.Location = new System.Drawing.Point(15, 19);
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.ReadOnly = true;
            this.korisniciDataGridView.Size = new System.Drawing.Size(443, 220);
            this.korisniciDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "korisnik_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "korisnik_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "korisnik";
            this.dataGridViewTextBoxColumn2.HeaderText = "korisnik";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lozinka";
            this.dataGridViewTextBoxColumn3.HeaderText = "lozinka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nivo";
            this.dataGridViewTextBoxColumn4.HeaderText = "nivo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(nivoLabel);
            this.panel4.Location = new System.Drawing.Point(21, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 39);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(korisnikLabel);
            this.panel5.Location = new System.Drawing.Point(21, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(97, 39);
            this.panel5.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Location = new System.Drawing.Point(12, 26);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(519, 320);
            this.panel9.TabIndex = 4;
            // 
            // korisniciTableAdapter
            // 
            this.korisniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisniciTableAdapter = this.korisniciTableAdapter;
            this.tableAdapterManager.lokacijaTableAdapter = null;
            this.tableAdapterManager.putnikTableAdapter = null;
            this.tableAdapterManager.rezervacijaTableAdapter = null;
            this.tableAdapterManager.turaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vozacTableAdapter = null;
            this.tableAdapterManager.voziloTableAdapter = null;
            // 
            // Korisnici_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(577, 661);
            this.Controls.Add(this.panel1);
            this.Name = "Korisnici_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.Korisnici_forma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private transport_menadzmentDataSetTableAdapters.korisniciTableAdapter korisniciTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView korisniciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox korisnik_idTextBox;
        private System.Windows.Forms.TextBox korisnikTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.ComboBox nivoComboBox;
        private System.Windows.Forms.Panel panel9;
    }
}