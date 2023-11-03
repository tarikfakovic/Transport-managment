namespace SistemPrevoz
{
    partial class Lokacija_forma
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
            System.Windows.Forms.Label lokacijaIDLabel2;
            System.Windows.Forms.Label gradLabel1;
            System.Windows.Forms.Label nazivLabel1;
            System.Windows.Forms.Label adresaLabel1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lokacijaIDTextBox = new System.Windows.Forms.TextBox();
            this.lokacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.gradTextBox1 = new System.Windows.Forms.TextBox();
            this.nazivTextBox1 = new System.Windows.Forms.TextBox();
            this.adresaTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lokacijaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnNapred = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lokacijaTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.lokacijaTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            lokacijaIDLabel2 = new System.Windows.Forms.Label();
            gradLabel1 = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            adresaLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lokacijaIDLabel2
            // 
            lokacijaIDLabel2.AutoSize = true;
            lokacijaIDLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            lokacijaIDLabel2.ForeColor = System.Drawing.SystemColors.Info;
            lokacijaIDLabel2.Location = new System.Drawing.Point(-2, 11);
            lokacijaIDLabel2.Name = "lokacijaIDLabel2";
            lokacijaIDLabel2.Size = new System.Drawing.Size(98, 19);
            lokacijaIDLabel2.TabIndex = 16;
            lokacijaIDLabel2.Text = "Lokacija ID:";
            // 
            // gradLabel1
            // 
            gradLabel1.AutoSize = true;
            gradLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            gradLabel1.ForeColor = System.Drawing.SystemColors.Info;
            gradLabel1.Location = new System.Drawing.Point(18, 6);
            gradLabel1.Name = "gradLabel1";
            gradLabel1.Size = new System.Drawing.Size(53, 19);
            gradLabel1.TabIndex = 18;
            gradLabel1.Text = "Grad:";
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            nazivLabel1.ForeColor = System.Drawing.SystemColors.Info;
            nazivLabel1.Location = new System.Drawing.Point(15, 6);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(56, 19);
            nazivLabel1.TabIndex = 20;
            nazivLabel1.Text = "Naziv:";
            // 
            // adresaLabel1
            // 
            adresaLabel1.AutoSize = true;
            adresaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            adresaLabel1.ForeColor = System.Drawing.SystemColors.Info;
            adresaLabel1.Location = new System.Drawing.Point(15, 9);
            adresaLabel1.Name = "adresaLabel1";
            adresaLabel1.Size = new System.Drawing.Size(68, 19);
            adresaLabel1.TabIndex = 22;
            adresaLabel1.Text = "Adresa:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lokacijaIDTextBox);
            this.panel1.Controls.Add(this.gradTextBox1);
            this.panel1.Controls.Add(this.nazivTextBox1);
            this.panel1.Controls.Add(this.adresaTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 647);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.Naslov);
            this.panel8.Location = new System.Drawing.Point(89, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 89);
            this.panel8.TabIndex = 28;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(101, 20);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(184, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Lokacije";
            this.Naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(lokacijaIDLabel2);
            this.panel7.Location = new System.Drawing.Point(43, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(97, 39);
            this.panel7.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(nazivLabel1);
            this.panel6.Location = new System.Drawing.Point(43, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(97, 39);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(adresaLabel1);
            this.panel5.Location = new System.Drawing.Point(43, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(97, 39);
            this.panel5.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(gradLabel1);
            this.panel4.Location = new System.Drawing.Point(43, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(97, 39);
            this.panel4.TabIndex = 25;
            // 
            // lokacijaIDTextBox
            // 
            this.lokacijaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijaBindingSource, "LokacijaID", true));
            this.lokacijaIDTextBox.Location = new System.Drawing.Point(173, 131);
            this.lokacijaIDTextBox.Name = "lokacijaIDTextBox";
            this.lokacijaIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.lokacijaIDTextBox.TabIndex = 17;
            // 
            // lokacijaBindingSource
            // 
            this.lokacijaBindingSource.DataMember = "lokacija";
            this.lokacijaBindingSource.DataSource = this.transport_menadzmentDataSet;
            // 
            // transport_menadzmentDataSet
            // 
            this.transport_menadzmentDataSet.DataSetName = "transport_menadzmentDataSet";
            this.transport_menadzmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradTextBox1
            // 
            this.gradTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijaBindingSource, "Grad", true));
            this.gradTextBox1.Location = new System.Drawing.Point(173, 188);
            this.gradTextBox1.Name = "gradTextBox1";
            this.gradTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gradTextBox1.TabIndex = 19;
            // 
            // nazivTextBox1
            // 
            this.nazivTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijaBindingSource, "Naziv", true));
            this.nazivTextBox1.Location = new System.Drawing.Point(173, 242);
            this.nazivTextBox1.Name = "nazivTextBox1";
            this.nazivTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox1.TabIndex = 21;
            // 
            // adresaTextBox1
            // 
            this.adresaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijaBindingSource, "Adresa", true));
            this.adresaTextBox1.Location = new System.Drawing.Point(173, 299);
            this.adresaTextBox1.Name = "adresaTextBox1";
            this.adresaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lokacijaDataGridView);
            this.panel2.Location = new System.Drawing.Point(54, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 263);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.lokacijaDataGridView.DataSource = this.lokacijaBindingSource;
            this.lokacijaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lokacijaDataGridView.Location = new System.Drawing.Point(13, 20);
            this.lokacijaDataGridView.Name = "lokacijaDataGridView";
            this.lokacijaDataGridView.ReadOnly = true;
            this.lokacijaDataGridView.Size = new System.Drawing.Size(443, 220);
            this.lokacijaDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LokacijaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LokacijaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Grad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Grad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn3.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Location = new System.Drawing.Point(30, 28);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(519, 319);
            this.panel9.TabIndex = 29;
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
            this.panel3.Location = new System.Drawing.Point(264, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 207);
            this.panel3.TabIndex = 9;
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
            this.btnNapred.Location = new System.Drawing.Point(21, 84);
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
            this.btnNazad.Location = new System.Drawing.Point(131, 84);
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
            this.btnIzbrisi.Location = new System.Drawing.Point(131, 21);
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
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(21, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 34);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lokacijaTableAdapter
            // 
            this.lokacijaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisniciTableAdapter = null;
            this.tableAdapterManager.lokacijaTableAdapter = this.lokacijaTableAdapter;
            this.tableAdapterManager.putnikTableAdapter = null;
            this.tableAdapterManager.rezervacijaTableAdapter = null;
            this.tableAdapterManager.turaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vozacTableAdapter = null;
            this.tableAdapterManager.voziloTableAdapter = null;
            // 
            // Lokacija_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(599, 671);
            this.Controls.Add(this.panel1);
            this.Name = "Lokacija_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Lokacija_forma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lokacijaDataGridView)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnNapred;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource lokacijaBindingSource;
        private transport_menadzmentDataSetTableAdapters.lokacijaTableAdapter lokacijaTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lokacijaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox lokacijaIDTextBox;
        private System.Windows.Forms.TextBox gradTextBox1;
        private System.Windows.Forms.TextBox nazivTextBox1;
        private System.Windows.Forms.TextBox adresaTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Panel panel9;
    }
}