namespace SistemPrevoz
{
    partial class Glavna_forma
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
            System.Windows.Forms.Label nivoLabel;
            this.boxNivo = new System.Windows.Forms.ComboBox();
            this.Login_forma = new System.Windows.Forms.Panel();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Naslov = new System.Windows.Forms.Label();
            this.transport_menadzmentDataSet = new SistemPrevoz.transport_menadzmentDataSet();
            this.korisniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisniciTableAdapter = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.korisniciTableAdapter();
            this.tableAdapterManager = new SistemPrevoz.transport_menadzmentDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            nivoLabel = new System.Windows.Forms.Label();
            this.Login_forma.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nivoLabel
            // 
            nivoLabel.AutoSize = true;
            nivoLabel.Location = new System.Drawing.Point(277, 148);
            nivoLabel.Name = "nivoLabel";
            nivoLabel.Size = new System.Drawing.Size(0, 13);
            nivoLabel.TabIndex = 17;
            // 
            // boxNivo
            // 
            this.boxNivo.BackColor = System.Drawing.SystemColors.Window;
            this.boxNivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxNivo.FormattingEnabled = true;
            this.boxNivo.Items.AddRange(new object[] {
            "Admin",
            "Korisnik"});
            this.boxNivo.Location = new System.Drawing.Point(117, 100);
            this.boxNivo.Name = "boxNivo";
            this.boxNivo.Size = new System.Drawing.Size(121, 21);
            this.boxNivo.TabIndex = 17;
            this.boxNivo.Tag = "";
            // 
            // Login_forma
            // 
            this.Login_forma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_forma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login_forma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Login_forma.Controls.Add(nivoLabel);
            this.Login_forma.Controls.Add(this.boxNivo);
            this.Login_forma.Controls.Add(this.btnPrijava);
            this.Login_forma.Controls.Add(this.label2);
            this.Login_forma.Controls.Add(this.label1);
            this.Login_forma.Controls.Add(this.txtLozinka);
            this.Login_forma.Controls.Add(this.txtKorisnik);
            this.Login_forma.Location = new System.Drawing.Point(175, 135);
            this.Login_forma.Name = "Login_forma";
            this.Login_forma.Size = new System.Drawing.Size(357, 203);
            this.Login_forma.TabIndex = 2;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(104, 139);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(146, 44);
            this.btnPrijava.TabIndex = 16;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisnik";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(219, 60);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(115, 20);
            this.txtLozinka.TabIndex = 1;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(21, 60);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(115, 20);
            this.txtKorisnik.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Naslov);
            this.panel1.Location = new System.Drawing.Point(60, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 76);
            this.panel1.TabIndex = 3;
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(12, 15);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(568, 44);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Prevoz Menadzment Sistem";
            // 
            // transport_menadzmentDataSet
            // 
            this.transport_menadzmentDataSet.DataSetName = "transport_menadzmentDataSet";
            this.transport_menadzmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisniciBindingSource
            // 
            this.korisniciBindingSource.DataMember = "korisnici";
            this.korisniciBindingSource.DataSource = this.transport_menadzmentDataSet;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(24, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 357);
            this.panel2.TabIndex = 4;
            // 
            // Glavna_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(716, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login_forma);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Glavna_forma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMS";
            this.Load += new System.EventHandler(this.Glavna_forma_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Glavna_forma_KeyPress);
            this.Login_forma.ResumeLayout(false);
            this.Login_forma.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transport_menadzmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Login_forma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.ComboBox boxNivo;
        private transport_menadzmentDataSet transport_menadzmentDataSet;
        private System.Windows.Forms.BindingSource korisniciBindingSource;
        private transport_menadzmentDataSetTableAdapters.korisniciTableAdapter korisniciTableAdapter;
        private transport_menadzmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
    }
}

