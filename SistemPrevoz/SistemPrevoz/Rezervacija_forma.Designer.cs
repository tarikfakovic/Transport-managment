namespace SistemPrevoz
{
    partial class Rezervacija_forma
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
            System.Windows.Forms.Label rezervacijaIDLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label kreiranaAtLabel;
            System.Windows.Forms.Label povratnaLabel;
            System.Windows.Forms.Label putnikIDLabel;
            System.Windows.Forms.Label turaIDLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.rezervacijaIDTextBox = new System.Windows.Forms.TextBox();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.kreiranaAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.povratnaComboBox = new System.Windows.Forms.ComboBox();
            this.putnikIDComboBox = new System.Windows.Forms.ComboBox();
            this.putnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turaIDComboBox = new System.Windows.Forms.ComboBox();
            this.turaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnNapred = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rezervacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rezervacijaTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.rezervacijaTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            this.putnikTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.putnikTableAdapter();
            this.turaTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.turaTableAdapter();
            this.rezervacijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            rezervacijaIDLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            kreiranaAtLabel = new System.Windows.Forms.Label();
            povratnaLabel = new System.Windows.Forms.Label();
            putnikIDLabel = new System.Windows.Forms.Label();
            turaIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turaBindingSource)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaDataGridView)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacijaIDLabel
            // 
            rezervacijaIDLabel.AutoSize = true;
            rezervacijaIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            rezervacijaIDLabel.ForeColor = System.Drawing.SystemColors.Info;
            rezervacijaIDLabel.Location = new System.Drawing.Point(3, 10);
            rezervacijaIDLabel.Name = "rezervacijaIDLabel";
            rezervacijaIDLabel.Size = new System.Drawing.Size(122, 19);
            rezervacijaIDLabel.TabIndex = 36;
            rezervacijaIDLabel.Text = "Rezervacija ID:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            cenaLabel.ForeColor = System.Drawing.SystemColors.Info;
            cenaLabel.Location = new System.Drawing.Point(21, 10);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(56, 19);
            cenaLabel.TabIndex = 38;
            cenaLabel.Text = "Cena:";
            // 
            // kreiranaAtLabel
            // 
            kreiranaAtLabel.AutoSize = true;
            kreiranaAtLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            kreiranaAtLabel.ForeColor = System.Drawing.SystemColors.Info;
            kreiranaAtLabel.Location = new System.Drawing.Point(12, 11);
            kreiranaAtLabel.Name = "kreiranaAtLabel";
            kreiranaAtLabel.Size = new System.Drawing.Size(99, 19);
            kreiranaAtLabel.TabIndex = 40;
            kreiranaAtLabel.Text = "Kreirana At:";
            // 
            // povratnaLabel
            // 
            povratnaLabel.AutoSize = true;
            povratnaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            povratnaLabel.ForeColor = System.Drawing.SystemColors.Info;
            povratnaLabel.Location = new System.Drawing.Point(10, 11);
            povratnaLabel.Name = "povratnaLabel";
            povratnaLabel.Size = new System.Drawing.Size(82, 19);
            povratnaLabel.TabIndex = 42;
            povratnaLabel.Text = "Povratna:";
            // 
            // putnikIDLabel
            // 
            putnikIDLabel.AutoSize = true;
            putnikIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            putnikIDLabel.ForeColor = System.Drawing.SystemColors.Info;
            putnikIDLabel.Location = new System.Drawing.Point(10, 10);
            putnikIDLabel.Name = "putnikIDLabel";
            putnikIDLabel.Size = new System.Drawing.Size(78, 19);
            putnikIDLabel.TabIndex = 44;
            putnikIDLabel.Text = "Putnik ID:";
            // 
            // turaIDLabel
            // 
            turaIDLabel.AutoSize = true;
            turaIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            turaIDLabel.ForeColor = System.Drawing.SystemColors.Info;
            turaIDLabel.Location = new System.Drawing.Point(10, 9);
            turaIDLabel.Name = "turaIDLabel";
            turaIDLabel.Size = new System.Drawing.Size(65, 19);
            turaIDLabel.TabIndex = 46;
            turaIDLabel.Text = "Tura ID:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rezervacijaIDTextBox);
            this.panel1.Controls.Add(this.cenaTextBox);
            this.panel1.Controls.Add(this.kreiranaAtDateTimePicker);
            this.panel1.Controls.Add(this.povratnaComboBox);
            this.panel1.Controls.Add(this.putnikIDComboBox);
            this.panel1.Controls.Add(this.turaIDComboBox);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 658);
            this.panel1.TabIndex = 2;
            // 
            // rezervacijaIDTextBox
            // 
            this.rezervacijaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijaBindingSource, "RezervacijaID", true));
            this.rezervacijaIDTextBox.Location = new System.Drawing.Point(166, 145);
            this.rezervacijaIDTextBox.Name = "rezervacijaIDTextBox";
            this.rezervacijaIDTextBox.Size = new System.Drawing.Size(111, 20);
            this.rezervacijaIDTextBox.TabIndex = 37;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataMember = "rezervacija";
            this.rezervacijaBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // transport_menadzmentDataSet
            // 
            this.transport_menadzmentDataSet.DataSetName = "transport_menadzmentDataSet";
            this.transport_menadzmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijaBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(166, 220);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(111, 20);
            this.cenaTextBox.TabIndex = 39;
            // 
            // kreiranaAtDateTimePicker
            // 
            this.kreiranaAtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervacijaBindingSource, "KreiranaAt", true));
            this.kreiranaAtDateTimePicker.Location = new System.Drawing.Point(159, 283);
            this.kreiranaAtDateTimePicker.Name = "kreiranaAtDateTimePicker";
            this.kreiranaAtDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.kreiranaAtDateTimePicker.TabIndex = 41;
            // 
            // povratnaComboBox
            // 
            this.povratnaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijaBindingSource, "Povratna", true));
            this.povratnaComboBox.FormattingEnabled = true;
            this.povratnaComboBox.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.povratnaComboBox.Location = new System.Drawing.Point(435, 144);
            this.povratnaComboBox.Name = "povratnaComboBox";
            this.povratnaComboBox.Size = new System.Drawing.Size(111, 21);
            this.povratnaComboBox.TabIndex = 43;
            // 
            // putnikIDComboBox
            // 
            this.putnikIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijaBindingSource, "PutnikID", true));
            this.putnikIDComboBox.DataSource = this.putnikBindingSource;
            this.putnikIDComboBox.DisplayMember = "PutnikID";
            this.putnikIDComboBox.FormattingEnabled = true;
            this.putnikIDComboBox.Location = new System.Drawing.Point(435, 215);
            this.putnikIDComboBox.Name = "putnikIDComboBox";
            this.putnikIDComboBox.Size = new System.Drawing.Size(111, 21);
            this.putnikIDComboBox.TabIndex = 45;
            // 
            // putnikBindingSource
            // 
            this.putnikBindingSource.DataMember = "putnik";
            this.putnikBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // turaIDComboBox
            // 
            this.turaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijaBindingSource, "TuraID", true));
            this.turaIDComboBox.DataSource = this.turaBindingSource;
            this.turaIDComboBox.DisplayMember = "TuraID";
            this.turaIDComboBox.FormattingEnabled = true;
            this.turaIDComboBox.Location = new System.Drawing.Point(435, 282);
            this.turaIDComboBox.Name = "turaIDComboBox";
            this.turaIDComboBox.Size = new System.Drawing.Size(111, 21);
            this.turaIDComboBox.TabIndex = 47;
            // 
            // turaBindingSource
            // 
            this.turaBindingSource.DataMember = "tura";
            this.turaBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(cenaLabel);
            this.panel9.Location = new System.Drawing.Point(38, 206);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(97, 39);
            this.panel9.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(povratnaLabel);
            this.panel6.Location = new System.Drawing.Point(302, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(97, 39);
            this.panel6.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(putnikIDLabel);
            this.panel5.Location = new System.Drawing.Point(302, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(97, 39);
            this.panel5.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(turaIDLabel);
            this.panel4.Location = new System.Drawing.Point(302, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 39);
            this.panel4.TabIndex = 33;
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
            this.panel3.Location = new System.Drawing.Point(577, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 207);
            this.panel3.TabIndex = 31;
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
            this.panel8.Location = new System.Drawing.Point(230, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 89);
            this.panel8.TabIndex = 29;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(66, 20);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(252, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Rezervacije";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rezervacijaDataGridView);
            this.panel2.Location = new System.Drawing.Point(82, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 273);
            this.panel2.TabIndex = 30;
            // 
            // rezervacijaDataGridView
            // 
            this.rezervacijaDataGridView.AllowUserToAddRows = false;
            this.rezervacijaDataGridView.AllowUserToDeleteRows = false;
            this.rezervacijaDataGridView.AutoGenerateColumns = false;
            this.rezervacijaDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.rezervacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervacijaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rezervacijaDataGridView.DataSource = this.rezervacijaBindingSource;
            this.rezervacijaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rezervacijaDataGridView.Location = new System.Drawing.Point(15, 13);
            this.rezervacijaDataGridView.Name = "rezervacijaDataGridView";
            this.rezervacijaDataGridView.ReadOnly = true;
            this.rezervacijaDataGridView.Size = new System.Drawing.Size(643, 241);
            this.rezervacijaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RezervacijaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RezervacijaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cena";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KreiranaAt";
            this.dataGridViewTextBoxColumn3.HeaderText = "KreiranaAt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Povratna";
            this.dataGridViewTextBoxColumn4.HeaderText = "Povratna";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PutnikID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PutnikID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TuraID";
            this.dataGridViewTextBoxColumn6.HeaderText = "TuraID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Location = new System.Drawing.Point(15, 29);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(817, 325);
            this.panel11.TabIndex = 48;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(rezervacijaIDLabel);
            this.panel7.Location = new System.Drawing.Point(8, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 39);
            this.panel7.TabIndex = 32;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(kreiranaAtLabel);
            this.panel10.Location = new System.Drawing.Point(16, 244);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(117, 39);
            this.panel10.TabIndex = 33;
            // 
            // rezervacijaTableAdapter
            // 
            this.rezervacijaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisniciTableAdapter = null;
            this.tableAdapterManager.lokacijaTableAdapter = null;
            this.tableAdapterManager.putnikTableAdapter = this.putnikTableAdapter;
            this.tableAdapterManager.rezervacijaTableAdapter = this.rezervacijaTableAdapter;
            this.tableAdapterManager.turaTableAdapter = this.turaTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vozacTableAdapter = null;
            this.tableAdapterManager.voziloTableAdapter = null;
            // 
            // putnikTableAdapter
            // 
            this.putnikTableAdapter.ClearBeforeFill = true;
            // 
            // turaTableAdapter
            // 
            this.turaTableAdapter.ClearBeforeFill = true;
            // 
            // rezervacijaBindingSource1
            // 
            this.rezervacijaBindingSource1.DataMember = "rezervacija";
            this.rezervacijaBindingSource1.DataSource = this.transport_menadzmentDataSet;
            // 
            // Rezervacija_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(878, 682);
            this.Controls.Add(this.panel1);
            this.Name = "Rezervacija_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Rezervacija_forma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turaBindingSource)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaDataGridView)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
        private transport_menadzmentDataSetTableAdapters.rezervacijaTableAdapter rezervacijaTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rezervacijaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox rezervacijaIDTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.DateTimePicker kreiranaAtDateTimePicker;
        private System.Windows.Forms.ComboBox povratnaComboBox;
        private System.Windows.Forms.ComboBox putnikIDComboBox;
        private System.Windows.Forms.ComboBox turaIDComboBox;
        private transport_menadzmentDataSetTableAdapters.putnikTableAdapter putnikTableAdapter;
        private System.Windows.Forms.BindingSource putnikBindingSource;
        private transport_menadzmentDataSetTableAdapters.turaTableAdapter turaTableAdapter;
        private System.Windows.Forms.BindingSource turaBindingSource;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource1;
        private System.Windows.Forms.Panel panel11;
    }
}