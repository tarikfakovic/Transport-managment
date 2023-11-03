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
    public partial class Tura_forma : Form
    {
        public Tura_forma()
        {
            InitializeComponent();
        }

        private void Tura_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.lokacija' table. You can move, or remove it, as needed.
            this.lokacijaTableAdapter.Fill(this.transport_menadzmentDataSet.lokacija);
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.vozac' table. You can move, or remove it, as needed.
            this.vozacTableAdapter.Fill(this.transport_menadzmentDataSet.vozac);
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.transport_menadzmentDataSet.vozilo);
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.tura' table. You can move, or remove it, as needed.
            this.turaTableAdapter.Fill(this.transport_menadzmentDataSet.tura);

        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.turaBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.turaBindingSource.RemoveCurrent();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.turaBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.turaBindingSource.MovePrevious();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult iCuvaj;

            iCuvaj = MessageBox.Show("Potvrdite cuvanje", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iCuvaj == DialogResult.Yes)
            {
                this.Validate();
                this.turaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
