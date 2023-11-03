using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemPrevoz
{
    public partial class Polasci_forma : Form
    {
        public Polasci_forma()
        {
            InitializeComponent();
        }

        private void Polasci_forma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transport_menadzmentDataSet.ture' table. You can move, or remove it, as needed.
            this.tureTableAdapter.Fill(this.transport_menadzmentDataSet.ture);

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            this.tureBindingSource.MoveNext();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.tureBindingSource.MovePrevious();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Create an instance of the PrintDialog
            using (PrintDialog printDialog = new PrintDialog())
            {
                // Set the PrintDocument property of the PrintDialog to your printDocument1
                printDialog.Document = printDocument1;

                // Show the Print Dialog
                DialogResult result = printDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // User clicked the "OK" button in the Print Dialog
                    // Perform the printing operation here
                    printDocument1.Print();
                }
            }
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Set the starting position for printing
            int startX = 10;
            int startY = 40;

            // Set the column width and row height for printing
            int columnWidth = 105;
            int rowHeight = 28;

            // Create a bold font with Century font family
            Font headerFont = new Font("Arial", 9, FontStyle.Bold);

            // Draw column names with the desired formatting
            for (int col = 0; col < tureDataGridView.Columns.Count; col++)
            {
                string columnName = tureDataGridView.Columns[col].HeaderText;
                RectangleF columnRect = new RectangleF(startX + (col * columnWidth), startY, columnWidth, rowHeight);

                // Measure the width and height of the text
                SizeF textSize = g.MeasureString(columnName, headerFont);

                // Calculate the center position for the text
                float textX = columnRect.X + (columnRect.Width - textSize.Width) / 2;
                float textY = columnRect.Y + (columnRect.Height - textSize.Height) / 2;

                // Draw the column name with bold and Century font, centered
                g.DrawString(columnName, headerFont, Brushes.Black, textX, textY);
                g.DrawRectangle(Pens.Black, columnRect.X, columnRect.Y, columnRect.Width, columnRect.Height);
            }

            Font cellFont = tureDataGridView.Font;
            startY += rowHeight;
            // Loop through the DataGridView rows and columns to draw the content
            for (int col = 0; col < tureDataGridView.Columns.Count; col++)
            {
                for (int row = 0; row < tureDataGridView.Rows.Count; row++)
                {
                    // Get the cell value
                    object cellValue = tureDataGridView.Rows[row].Cells[col].Value;

                    // Calculate the position to draw the cell
                    RectangleF cellRect = new RectangleF(startX + (col * columnWidth), startY + (row * rowHeight), columnWidth, rowHeight);

                    // Measure the width and height of the text
                    SizeF textSize = g.MeasureString(cellValue.ToString(), cellFont);

                    // Calculate the center position for the text
                    float textX = cellRect.X + (cellRect.Width - textSize.Width) / 2;
                    float textY = cellRect.Y + (cellRect.Height - textSize.Height) / 2;

                    // Draw the cell content, center-aligned
                    g.DrawString(cellValue.ToString(), cellFont, Brushes.Black, textX, textY);

                    // Draw cell borders
                    g.DrawRectangle(Pens.Black, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }













            // Increment the starting position for printing rows
            /*startY += rowHeight;*/

            /*            // Loop through the DataGridView rows and columns to draw the content
                        for (int col = 0; col < tureDataGridView.Columns.Count; col++)
                        {
                            for (int row = 0; row < tureDataGridView.Rows.Count; row++)
                            {
                                // Get the cell value
                                object cellValue = tureDataGridView.Rows[row].Cells[col].Value;

                                // Calculate the position to draw the cell
                                RectangleF cellRect = new RectangleF(startX + (col * columnWidth), startY + (row * rowHeight), columnWidth, rowHeight);

                                // Draw the cell content
                                g.DrawString(cellValue.ToString(), tureDataGridView.Font, Brushes.Black, cellRect);

                                // Draw cell borders
                                g.DrawRectangle(Pens.Black, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                            }
                        }*/
        }
    }
}
