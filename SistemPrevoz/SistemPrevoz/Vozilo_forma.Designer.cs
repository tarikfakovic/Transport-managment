namespace SistemPrevoz
{
    partial class Vozilo_forma
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
            System.Windows.Forms.Label voziloIDLabel;
            System.Windows.Forms.Label brendLabel;
            System.Windows.Forms.Label tipLabel;
            System.Windows.Forms.Label bojaLabel;
            System.Windows.Forms.Label brojSedistaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lokacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSedistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.panel11 = new System.Windows.Forms.Panel();
            this.voziloIDTextBox = new System.Windows.Forms.TextBox();
            this.brendTextBox = new System.Windows.Forms.TextBox();
            this.tipComboBox = new System.Windows.Forms.ComboBox();
            this.bojaTextBox = new System.Windows.Forms.TextBox();
            this.brojSedistaTextBox = new System.Windows.Forms.TextBox();
            this.voziloTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.voziloTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            voziloIDLabel = new System.Windows.Forms.Label();
            brendLabel = new System.Windows.Forms.Label();
            tipLabel = new System.Windows.Forms.Label();
            bojaLabel = new System.Windows.Forms.Label();
            brojSedistaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // voziloIDLabel
            // 
            voziloIDLabel.AutoSize = true;
            voziloIDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            voziloIDLabel.ForeColor = System.Drawing.SystemColors.Info;
            voziloIDLabel.Location = new System.Drawing.Point(10, 10);
            voziloIDLabel.Name = "voziloIDLabel";
            voziloIDLabel.Size = new System.Drawing.Size(78, 19);
            voziloIDLabel.TabIndex = 0;
            voziloIDLabel.Text = "Vozilo ID:";
            // 
            // brendLabel
            // 
            brendLabel.AutoSize = true;
            brendLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            brendLabel.ForeColor = System.Drawing.SystemColors.Info;
            brendLabel.Location = new System.Drawing.Point(19, 10);
            brendLabel.Name = "brendLabel";
            brendLabel.Size = new System.Drawing.Size(58, 19);
            brendLabel.TabIndex = 2;
            brendLabel.Text = "Brend:";
            // 
            // tipLabel
            // 
            tipLabel.AutoSize = true;
            tipLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            tipLabel.ForeColor = System.Drawing.SystemColors.Info;
            tipLabel.Location = new System.Drawing.Point(30, 10);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new System.Drawing.Size(35, 19);
            tipLabel.TabIndex = 4;
            tipLabel.Text = "Tip:";
            // 
            // bojaLabel
            // 
            bojaLabel.AutoSize = true;
            bojaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            bojaLabel.ForeColor = System.Drawing.SystemColors.Info;
            bojaLabel.Location = new System.Drawing.Point(25, 10);
            bojaLabel.Name = "bojaLabel";
            bojaLabel.Size = new System.Drawing.Size(47, 19);
            bojaLabel.TabIndex = 6;
            bojaLabel.Text = "Boja:";
            // 
            // brojSedistaLabel
            // 
            brojSedistaLabel.AutoSize = true;
            brojSedistaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            brojSedistaLabel.ForeColor = System.Drawing.SystemColors.Info;
            brojSedistaLabel.Location = new System.Drawing.Point(-3, 10);
            brojSedistaLabel.Name = "brojSedistaLabel";
            brojSedistaLabel.Size = new System.Drawing.Size(99, 19);
            brojSedistaLabel.TabIndex = 8;
            brojSedistaLabel.Text = "Broj Sedista:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 629);
            this.panel1.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(bojaLabel);
            this.panel10.Location = new System.Drawing.Point(293, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(97, 39);
            this.panel10.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(brojSedistaLabel);
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
            this.Naslov.Size = new System.Drawing.Size(139, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Vozila";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(voziloIDLabel);
            this.panel7.Location = new System.Drawing.Point(33, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 39);
            this.panel7.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(tipLabel);
            this.panel6.Location = new System.Drawing.Point(33, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(97, 39);
            this.panel6.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(brendLabel);
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
            this.panel2.Location = new System.Drawing.Point(137, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 258);
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
            this.voziloIDDataGridViewTextBoxColumn,
            this.brendDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.brojSedistaDataGridViewTextBoxColumn});
            this.lokacijaDataGridView.DataSource = this.voziloBindingSource;
            this.lokacijaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lokacijaDataGridView.Location = new System.Drawing.Point(13, 16);
            this.lokacijaDataGridView.Name = "lokacijaDataGridView";
            this.lokacijaDataGridView.ReadOnly = true;
            this.lokacijaDataGridView.Size = new System.Drawing.Size(544, 220);
            this.lokacijaDataGridView.TabIndex = 9;
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            this.voziloIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brendDataGridViewTextBoxColumn
            // 
            this.brendDataGridViewTextBoxColumn.DataPropertyName = "Brend";
            this.brendDataGridViewTextBoxColumn.HeaderText = "Brend";
            this.brendDataGridViewTextBoxColumn.Name = "brendDataGridViewTextBoxColumn";
            this.brendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojSedistaDataGridViewTextBoxColumn
            // 
            this.brojSedistaDataGridViewTextBoxColumn.DataPropertyName = "BrojSedista";
            this.brojSedistaDataGridViewTextBoxColumn.HeaderText = "BrojSedista";
            this.brojSedistaDataGridViewTextBoxColumn.Name = "brojSedistaDataGridViewTextBoxColumn";
            this.brojSedistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataMember = "vozilo";
            this.voziloBindingSource.DataSource = this.transport_menadzmentDataSet;
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
            this.panel11.Controls.Add(this.voziloIDTextBox);
            this.panel11.Controls.Add(this.brendTextBox);
            this.panel11.Controls.Add(this.tipComboBox);
            this.panel11.Controls.Add(this.bojaTextBox);
            this.panel11.Controls.Add(this.brojSedistaTextBox);
            this.panel11.Location = new System.Drawing.Point(18, 26);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(802, 316);
            this.panel11.TabIndex = 43;
            // 
            // voziloIDTextBox
            // 
            this.voziloIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "VoziloID", true));
            this.voziloIDTextBox.Location = new System.Drawing.Point(137, 117);
            this.voziloIDTextBox.Name = "voziloIDTextBox";
            this.voziloIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.voziloIDTextBox.TabIndex = 1;
            // 
            // brendTextBox
            // 
            this.brendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "Brend", true));
            this.brendTextBox.Location = new System.Drawing.Point(137, 183);
            this.brendTextBox.Name = "brendTextBox";
            this.brendTextBox.Size = new System.Drawing.Size(100, 20);
            this.brendTextBox.TabIndex = 3;
            // 
            // tipComboBox
            // 
            this.tipComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "Tip", true));
            this.tipComboBox.FormattingEnabled = true;
            this.tipComboBox.Items.AddRange(new object[] {
            "Mini-bus",
            "Kombi",
            "Mini-van",
            "Auto"});
            this.tipComboBox.Location = new System.Drawing.Point(137, 250);
            this.tipComboBox.Name = "tipComboBox";
            this.tipComboBox.Size = new System.Drawing.Size(100, 21);
            this.tipComboBox.TabIndex = 5;
            // 
            // bojaTextBox
            // 
            this.bojaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "Boja", true));
            this.bojaTextBox.Location = new System.Drawing.Point(404, 117);
            this.bojaTextBox.Name = "bojaTextBox";
            this.bojaTextBox.Size = new System.Drawing.Size(100, 20);
            this.bojaTextBox.TabIndex = 7;
            // 
            // brojSedistaTextBox
            // 
            this.brojSedistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "BrojSedista", true));
            this.brojSedistaTextBox.Location = new System.Drawing.Point(404, 180);
            this.brojSedistaTextBox.Name = "brojSedistaTextBox";
            this.brojSedistaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojSedistaTextBox.TabIndex = 9;
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.vozacTableAdapter = null;
            this.tableAdapterManager.voziloTableAdapter = this.voziloTableAdapter;
            // 
            // Vozilo_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(871, 654);
            this.Controls.Add(this.panel1);
            this.Name = "Vozilo_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Vozilo_forma_Load);
            this.panel1.ResumeLayout(false);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView lokacijaDataGridView;
        private System.Windows.Forms.Panel panel11;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private transport_menadzmentDataSetTableAdapters.voziloTableAdapter voziloTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSedistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox voziloIDTextBox;
        private System.Windows.Forms.TextBox brendTextBox;
        private System.Windows.Forms.ComboBox tipComboBox;
        private System.Windows.Forms.TextBox bojaTextBox;
        private System.Windows.Forms.TextBox brojSedistaTextBox;
    }
}