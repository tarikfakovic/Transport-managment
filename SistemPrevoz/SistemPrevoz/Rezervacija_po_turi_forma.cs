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
    public partial class Rezervacija_po_turi_forma : Form
    {
        public Rezervacija_po_turi_forma()
        {
            InitializeComponent();
        }


        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                this.rezervacija_po_turiTableAdapter.Fill(this.transport_menadzmentDataSet.rezervacija_po_turi, new System.Nullable<int>(((int)(System.Convert.ChangeType(inputBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
