namespace SistemPrevoz
{
    partial class Putnik_forma
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
            System.Windows.Forms.Label putnikIDLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label godineLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.putnikIDTextBox = new System.Windows.Forms.TextBox();
            this.putnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.godineTextBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnNapred = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lokacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.putnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.putnikTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.putnikTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            putnikIDLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            godineLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // putnikIDLabel
            // 
            putnikIDLabel.AutoSize = true;
            putnikIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            putnikIDLabel.ForeColor = System.Drawing.SystemColors.Info;
            putnikIDLabel.Location = new System.Drawing.Point(14, 8);
            putnikIDLabel.Name = "putnikIDLabel";
            putnikIDLabel.Size = new System.Drawing.Size(78, 19);
            putnikIDLabel.TabIndex = 31;
            putnikIDLabel.Text = "Putnik ID:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            imeLabel.ForeColor = System.Drawing.SystemColors.Info;
            imeLabel.Location = new System.Drawing.Point(29, 7);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(43, 19);
            imeLabel.TabIndex = 33;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            prezimeLabel.ForeColor = System.Drawing.SystemColors.Info;
            prezimeLabel.Location = new System.Drawing.Point(14, 9);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(74, 19);
            prezimeLabel.TabIndex = 35;
            prezimeLabel.Text = "Prezime:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            adresaLabel.ForeColor = System.Drawing.SystemColors.Info;
            adresaLabel.Location = new System.Drawing.Point(12, 8);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(68, 19);
            adresaLabel.TabIndex = 37;
            adresaLabel.Text = "Adresa:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            telefonLabel.Location = new System.Drawing.Point(18, 9);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(65, 19);
            telefonLabel.TabIndex = 39;
            telefonLabel.Text = "telefon:";
            // 
            // godineLabel
            // 
            godineLabel.AutoSize = true;
            godineLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            godineLabel.ForeColor = System.Drawing.SystemColors.Info;
            godineLabel.Location = new System.Drawing.Point(12, 11);
            godineLabel.Name = "godineLabel";
            godineLabel.Size = new System.Drawing.Size(71, 19);
            godineLabel.TabIndex = 41;
            godineLabel.Text = "Godine:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.putnikIDTextBox);
            this.panel1.Controls.Add(this.imeTextBox);
            this.panel1.Controls.Add(this.prezimeTextBox);
            this.panel1.Controls.Add(this.adresaTextBox);
            this.panel1.Controls.Add(this.telefonTextBox);
            this.panel1.Controls.Add(this.godineTextBox);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 629);
            this.panel1.TabIndex = 1;
            // 
            // putnikIDTextBox
            // 
            this.putnikIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putnikBindingSource, "PutnikID", true));
            this.putnikIDTextBox.Location = new System.Drawing.Point(157, 143);
            this.putnikIDTextBox.Name = "putnikIDTextBox";
            this.putnikIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.putnikIDTextBox.TabIndex = 32;
            // 
            // putnikBindingSource
            // 
            this.putnikBindingSource.DataMember = "putnik";
            this.putnikBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // transport_menadzmentDataSet
            // 
            this.transport_menadzmentDataSet.DataSetName = "transport_menadzmentDataSet";
            this.transport_menadzmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putnikBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(157, 208);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 34;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putnikBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(157, 274);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 36;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putnikBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(426, 143);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 38;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putnikBindingSource, "telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(426, 210);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 40;
            // 
            // godineTextBox
            // 
            this.godineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putnikBindingSource, "Godine", true));
            this.godineTextBox.Location = new System.Drawing.Point(426, 274);
            this.godineTextBox.Name = "godineTextBox";
            this.godineTextBox.Size = new System.Drawing.Size(100, 20);
            this.godineTextBox.TabIndex = 42;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(adresaLabel);
            this.panel10.Location = new System.Drawing.Point(293, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(97, 39);
            this.panel10.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(telefonLabel);
            this.panel9.ForeColor = System.Drawing.SystemColors.Info;
            this.panel9.Location = new System.Drawing.Point(293, 198);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(97, 39);
            this.panel9.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnIzlaz);
            this.panel3.Controls.Add(this.btnSacuvaj);
            this.panel3.Controls.Add(this.btnNapred);
            this.panel3.Controls.Add(this.btnNazad);
            this.panel3.Controls.Add(this.btnIzbrisi);
            this.panel3.Controls.Add(this.btnDodaj);
            this.panel3.Location = new System.Drawing.Point(566, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 207);
            this.panel3.TabIndex = 29;
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
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.Naslov);
            this.panel8.Location = new System.Drawing.Point(224, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 89);
            this.panel8.TabIndex = 28;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(110, 20);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(163, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Putnici";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(putnikIDLabel);
            this.panel7.Location = new System.Drawing.Point(33, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 39);
            this.panel7.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(prezimeLabel);
            this.panel6.Location = new System.Drawing.Point(33, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(97, 39);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(godineLabel);
            this.panel5.Location = new System.Drawing.Point(293, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(97, 39);
            this.panel5.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(imeLabel);
            this.panel4.Location = new System.Drawing.Point(33, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 39);
            this.panel4.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lokacijaDataGridView);
            this.panel2.Location = new System.Drawing.Point(82, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 258);
            this.panel2.TabIndex = 24;
            // 
            // lokacijaDataGridView
            // 
            this.lokacijaDataGridView.AllowUserToAddRows = false;
            this.lokacijaDataGridView.AllowUserToDeleteRows = false;
            this.lokacijaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lokacijaDataGridView.AutoGenerateColumns = false;
            this.lokacijaDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.lokacijaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lokacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lokacijaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.putnikIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.godineDataGridViewTextBoxColumn});
            this.lokacijaDataGridView.DataSource = this.putnikBindingSource;
            this.lokacijaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lokacijaDataGridView.Location = new System.Drawing.Point(13, 16);
            this.lokacijaDataGridView.Name = "lokacijaDataGridView";
            this.lokacijaDataGridView.ReadOnly = true;
            this.lokacijaDataGridView.Size = new System.Drawing.Size(643, 220);
            this.lokacijaDataGridView.TabIndex = 9;
            // 
            // putnikIDDataGridViewTextBoxColumn
            // 
            this.putnikIDDataGridViewTextBoxColumn.DataPropertyName = "PutnikID";
            this.putnikIDDataGridViewTextBoxColumn.HeaderText = "PutnikID";
            this.putnikIDDataGridViewTextBoxColumn.Name = "putnikIDDataGridViewTextBoxColumn";
            this.putnikIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godineDataGridViewTextBoxColumn
            // 
            this.godineDataGridViewTextBoxColumn.DataPropertyName = "Godine";
            this.godineDataGridViewTextBoxColumn.HeaderText = "Godine";
            this.godineDataGridViewTextBoxColumn.Name = "godineDataGridViewTextBoxColumn";
            this.godineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Location = new System.Drawing.Point(18, 26);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(802, 316);
            this.panel11.TabIndex = 43;
            // 
            // putnikTableAdapter
            // 
            this.putnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisniciTableAdapter = null;
            this.tableAdapterManager.lokacijaTableAdapter = null;
            this.tableAdapterManager.putnikTableAdapter = this.putnikTableAdapter;
            this.tableAdapterManager.rezervacijaTableAdapter = null;
            this.tableAdapterManager.turaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vozacTableAdapter = null;
            this.tableAdapterManager.voziloTableAdapter = null;
            // 
            // Putnik_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(869, 676);
            this.Controls.Add(this.panel1);
            this.Name = "Putnik_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Putnik_forma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView lokacijaDataGridView;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource putnikBindingSource;
        private transport_menadzmentDataSetTableAdapters.putnikTableAdapter putnikTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn putnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox putnikIDTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox godineTextBox;
        private System.Windows.Forms.Panel panel11;
    }
}