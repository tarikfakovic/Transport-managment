namespace SistemPrevoz
{
    partial class Vozac_forma
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
            System.Windows.Forms.Label vozacIDLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label godineLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label zaposljenAtLabel;
            System.Windows.Forms.Label kategorijaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lokacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.vozacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposljenAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.panel11 = new System.Windows.Forms.Panel();
            this.kategorijaComboBox = new System.Windows.Forms.ComboBox();
            this.vozacIDTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnNapred = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.godineTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.zaposljenAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.vozacTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.vozacTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            vozacIDLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            godineLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            zaposljenAtLabel = new System.Windows.Forms.Label();
            kategorijaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // vozacIDLabel
            // 
            vozacIDLabel.AutoSize = true;
            vozacIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            vozacIDLabel.ForeColor = System.Drawing.SystemColors.Info;
            vozacIDLabel.Location = new System.Drawing.Point(8, 11);
            vozacIDLabel.Name = "vozacIDLabel";
            vozacIDLabel.Size = new System.Drawing.Size(81, 19);
            vozacIDLabel.TabIndex = 0;
            vozacIDLabel.Text = "Vozac ID:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            imeLabel.ForeColor = System.Drawing.SystemColors.Info;
            imeLabel.Location = new System.Drawing.Point(25, 11);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(43, 19);
            imeLabel.TabIndex = 2;
            imeLabel.Text = "Ime:";
            // 
            // godineLabel
            // 
            godineLabel.AutoSize = true;
            godineLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            godineLabel.ForeColor = System.Drawing.SystemColors.Info;
            godineLabel.Location = new System.Drawing.Point(8, 12);
            godineLabel.Name = "godineLabel";
            godineLabel.Size = new System.Drawing.Size(71, 19);
            godineLabel.TabIndex = 4;
            godineLabel.Text = "Godine:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            telefonLabel.ForeColor = System.Drawing.SystemColors.Info;
            telefonLabel.Location = new System.Drawing.Point(14, 11);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(68, 19);
            telefonLabel.TabIndex = 6;
            telefonLabel.Text = "Telefon:";
            // 
            // zaposljenAtLabel
            // 
            zaposljenAtLabel.AutoSize = true;
            zaposljenAtLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            zaposljenAtLabel.ForeColor = System.Drawing.SystemColors.Info;
            zaposljenAtLabel.Location = new System.Drawing.Point(4, 10);
            zaposljenAtLabel.Name = "zaposljenAtLabel";
            zaposljenAtLabel.Size = new System.Drawing.Size(107, 19);
            zaposljenAtLabel.TabIndex = 10;
            zaposljenAtLabel.Text = "Zaposljen At:";
            // 
            // kategorijaLabel
            // 
            kategorijaLabel.AutoSize = true;
            kategorijaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            kategorijaLabel.Location = new System.Drawing.Point(3, 9);
            kategorijaLabel.Name = "kategorijaLabel";
            kategorijaLabel.Size = new System.Drawing.Size(93, 19);
            kategorijaLabel.TabIndex = 11;
            kategorijaLabel.Text = "Kategorija:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 652);
            this.panel1.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(telefonLabel);
            this.panel10.Location = new System.Drawing.Point(293, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(97, 39);
            this.panel10.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(kategorijaLabel);
            this.panel9.ForeColor = System.Drawing.SystemColors.Info;
            this.panel9.Location = new System.Drawing.Point(293, 198);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(97, 39);
            this.panel9.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.Naslov);
            this.panel8.Location = new System.Drawing.Point(227, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 89);
            this.panel8.TabIndex = 28;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(122, 20);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(147, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Vozaci";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(vozacIDLabel);
            this.panel7.Location = new System.Drawing.Point(33, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 39);
            this.panel7.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(godineLabel);
            this.panel6.Location = new System.Drawing.Point(33, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(97, 39);
            this.panel6.TabIndex = 27;
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lokacijaDataGridView);
            this.panel2.Location = new System.Drawing.Point(91, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 258);
            this.panel2.TabIndex = 24;
            // 
            // lokacijaDataGridView
            // 
            this.lokacijaDataGridView.AllowUserToAddRows = false;
            this.lokacijaDataGridView.AllowUserToDeleteRows = false;
            this.lokacijaDataGridView.AutoGenerateColumns = false;
            this.lokacijaDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.lokacijaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lokacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lokacijaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vozacIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.godineDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.zaposljenAtDataGridViewTextBoxColumn});
            this.lokacijaDataGridView.DataSource = this.vozacBindingSource;
            this.lokacijaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lokacijaDataGridView.Location = new System.Drawing.Point(13, 16);
            this.lokacijaDataGridView.Name = "lokacijaDataGridView";
            this.lokacijaDataGridView.ReadOnly = true;
            this.lokacijaDataGridView.Size = new System.Drawing.Size(643, 220);
            this.lokacijaDataGridView.TabIndex = 9;
            // 
            // vozacIDDataGridViewTextBoxColumn
            // 
            this.vozacIDDataGridViewTextBoxColumn.DataPropertyName = "VozacID";
            this.vozacIDDataGridViewTextBoxColumn.HeaderText = "VozacID";
            this.vozacIDDataGridViewTextBoxColumn.Name = "vozacIDDataGridViewTextBoxColumn";
            this.vozacIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godineDataGridViewTextBoxColumn
            // 
            this.godineDataGridViewTextBoxColumn.DataPropertyName = "Godine";
            this.godineDataGridViewTextBoxColumn.HeaderText = "Godine";
            this.godineDataGridViewTextBoxColumn.Name = "godineDataGridViewTextBoxColumn";
            this.godineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposljenAtDataGridViewTextBoxColumn
            // 
            this.zaposljenAtDataGridViewTextBoxColumn.DataPropertyName = "ZaposljenAt";
            this.zaposljenAtDataGridViewTextBoxColumn.HeaderText = "ZaposljenAt";
            this.zaposljenAtDataGridViewTextBoxColumn.Name = "zaposljenAtDataGridViewTextBoxColumn";
            this.zaposljenAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vozacBindingSource
            // 
            this.vozacBindingSource.DataMember = "vozac";
            this.vozacBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // transport_menadzmentDataSet
            // 
            this.transport_menadzmentDataSet.DataSetName = "transport_menadzmentDataSet";
            this.transport_menadzmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.kategorijaComboBox);
            this.panel11.Controls.Add(this.vozacIDTextBox);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.imeTextBox);
            this.panel11.Controls.Add(this.godineTextBox);
            this.panel11.Controls.Add(this.telefonTextBox);
            this.panel11.Controls.Add(this.zaposljenAtDateTimePicker);
            this.panel11.Controls.Add(this.panel5);
            this.panel11.Location = new System.Drawing.Point(17, 34);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(825, 318);
            this.panel11.TabIndex = 43;
            // 
            // kategorijaComboBox
            // 
            this.kategorijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozacBindingSource, "Kategorija", true));
            this.kategorijaComboBox.FormattingEnabled = true;
            this.kategorijaComboBox.Items.AddRange(new object[] {
            "B",
            "D"});
            this.kategorijaComboBox.Location = new System.Drawing.Point(440, 174);
            this.kategorijaComboBox.Name = "kategorijaComboBox";
            this.kategorijaComboBox.Size = new System.Drawing.Size(61, 21);
            this.kategorijaComboBox.TabIndex = 12;
            // 
            // vozacIDTextBox
            // 
            this.vozacIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozacBindingSource, "VozacID", true));
            this.vozacIDTextBox.Location = new System.Drawing.Point(155, 107);
            this.vozacIDTextBox.Name = "vozacIDTextBox";
            this.vozacIDTextBox.Size = new System.Drawing.Size(61, 20);
            this.vozacIDTextBox.TabIndex = 1;
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
            this.panel3.Location = new System.Drawing.Point(560, 84);
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
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozacBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(136, 176);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(106, 20);
            this.imeTextBox.TabIndex = 3;
            // 
            // godineTextBox
            // 
            this.godineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozacBindingSource, "Godine", true));
            this.godineTextBox.Location = new System.Drawing.Point(155, 241);
            this.godineTextBox.Name = "godineTextBox";
            this.godineTextBox.Size = new System.Drawing.Size(61, 20);
            this.godineTextBox.TabIndex = 5;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozacBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(408, 110);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefonTextBox.TabIndex = 7;
            // 
            // zaposljenAtDateTimePicker
            // 
            this.zaposljenAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vozacBindingSource, "ZaposljenAt", true));
            this.zaposljenAtDateTimePicker.Location = new System.Drawing.Point(397, 241);
            this.zaposljenAtDateTimePicker.Name = "zaposljenAtDateTimePicker";
            this.zaposljenAtDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.zaposljenAtDateTimePicker.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(zaposljenAtLabel);
            this.panel5.Location = new System.Drawing.Point(268, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 39);
            this.panel5.TabIndex = 26;
            // 
            // vozacTableAdapter
            // 
            this.vozacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisniciTableAdapter = null;
            this.tableAdapterManager.lokacijaTableAdapter = null;
            this.tableAdapterManager.putnikTableAdapter = null;
            this.tableAdapterManager.rezervacijaTableAdapter = null;
            this.tableAdapterManager.turaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vozacTableAdapter = this.vozacTableAdapter;
            this.tableAdapterManager.voziloTableAdapter = null;
            // 
            // Vozac_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(889, 677);
            this.Controls.Add(this.panel1);
            this.Name = "Vozac_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Vozac_forma_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView lokacijaDataGridView;
        private System.Windows.Forms.Panel panel11;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource vozacBindingSource;
        private transport_menadzmentDataSetTableAdapters.vozacTableAdapter vozacTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposljenAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox vozacIDTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox godineTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.DateTimePicker zaposljenAtDateTimePicker;
        private System.Windows.Forms.ComboBox kategorijaComboBox;
    }
}