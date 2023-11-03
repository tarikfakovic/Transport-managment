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
    public partial class Rezervacija_forma : Form
    {
        public Rezervacija_forma()
        {
            InitializeComponent();
        }


        private void Rezervacija_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.tura' table. You can move, or remove it, as needed.
            this.turaTableAdapter.Fill(this.transport_menadzmentDataSet.tura);
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.putnik' table. You can move, or remove it, as needed.
            this.putnikTableAdapter.Fill(this.transport_menadzmentDataSet.putnik);
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.rezervacija' table. You can move, or remove it, as needed.
            this.rezervacijaTableAdapter.Fill(this.transport_menadzmentDataSet.rezervacija);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.rezervacijaBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.rezervacijaBindingSource.RemoveCurrent();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.rezervacijaBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.rezervacijaBindingSource.MovePrevious();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult iCuvaj;

            iCuvaj = MessageBox.Show("Potvrdite cuvanje", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iCuvaj == DialogResult.Yes)
            {
                this.Validate();
                this.rezervacijaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
