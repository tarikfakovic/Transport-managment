using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemPrevoz
{
    public partial class Korisnici_forma : Form
    {
        public Korisnici_forma()
        {
            InitializeComponent();
        }


        private void Korisnici_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.korisnici' table. You can move, or remove it, as needed.
            this.korisniciTableAdapter.Fill(this.transport_menadzmentDataSet.korisnici);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.korisniciBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.korisniciBindingSource.RemoveCurrent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult iCuvaj;

            iCuvaj = MessageBox.Show("Potvrdite cuvanje", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iCuvaj == DialogResult.Yes)
            {
                this.Validate();
                this.korisniciBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);
            }
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.korisniciBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.korisniciBindingSource.MovePrevious();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
