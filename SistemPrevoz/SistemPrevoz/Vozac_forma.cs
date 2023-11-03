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
    public partial class Vozac_forma : Form
    {
        public Vozac_forma()
        {
            InitializeComponent();
        }

        private void Vozac_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.vozac' table. You can move, or remove it, as needed.
            this.vozacTableAdapter.Fill(this.transport_menadzmentDataSet.vozac);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.vozacBindingSource.AddNew();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            this.vozacBindingSource.RemoveCurrent();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.vozacBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.vozacBindingSource.MovePrevious();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult iCuvaj;

            iCuvaj = MessageBox.Show("Potvrdite cuvanje", "Transport menadzment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iCuvaj == DialogResult.Yes)
            {
                this.Validate();
                this.vozacBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.transport_menadzmentDataSet);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
