using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVUpload
{
    public partial class Form1 : Form
    {
        DataTable formDt = new DataTable();
        Color searchBtGreen = Color.FromArgb(102, 240, 102);

        //private void ShowSearchTermNotFoundMessage(string searchTerm)
        //{
        //    Form messageBox = new Form();
        //    messageBox.Text = "Message";
        //    messageBox.FormBorderStyle = FormBorderStyle.FixedDialog;
        //    messageBox.MaximizeBox = false;
        //    messageBox.MinimizeBox = false;

        //    Label label = new Label();
        //    label.Text = String.Format("Address '{0}' not found.", searchTerm);
        //    label.AutoSize = true;
        //    label.Location = new Point(10, 10);
        //    label.ForeColor = Color.Black;
        //    label.Font = new Font(label.Font, FontStyle.Regular);

        //    // Highlight the search term
        //    int startIndex = label.Text.IndexOf(searchTerm);
        //    if (startIndex >= 0)
        //    {
        //        label.ForeColor = Color.Yellow;
        //    }

        //    messageBox.ClientSize = new Size(Math.Max(200, label.Width + 20), label.Height + 20);
        //    messageBox.Controls.Add(label);
        //    messageBox.ShowDialog();
        //}
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.WrapContents = false;
            flpImport.WrapContents = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            ttBtImport.SetToolTip(btImportData, "Import a CSV from Hard Drive.");
            ttBtImport.SetToolTip(ckbKeepLocation, "Save the last location you load the File.");
            ttBtImport.SetToolTip(tbSearchTerm, "Enter a address to search.");

            //    // Calculate the width and height of the form to cover 80% of the screen resolution
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            //    int boxSize = (int)(Math.Min(screenWidth, screenHeight) * 0.8);

            // Set the size of the form
            //this.Size = new Size(boxSize, boxSize);

            // Set the location of the form to center it on the screen
            int x = (screenWidth - this.Width) / 2;
            int y = (screenHeight - this.Height) / 2;
            this.Location = new Point(x, y);

            ofdCsvData.Title = "Import From CSV";

            if (formDt != null && formDt.Rows.Count == 0)
            {
                btSearch.Enabled = false;
            }
        }


        private void btImportData_Click(object sender, EventArgs e)
        {

            if (ckbKeepLocation.Checked)
            {
                ofdCsvData.InitialDirectory = null;
                ofdCsvData.RestoreDirectory = true;

            }
            else
            {
                ofdCsvData.InitialDirectory = @"F:\Alain\C#\KO";
                ofdCsvData.RestoreDirectory = false;
            }

            if (ofdCsvData.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(ofdCsvData.FileName);
                string[] headers = lines[0].Split(',');
                tbSearchTerm.Text = "";
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    dt.Rows.Add(fields);
                }

                this.formDt = dt;
                dgvCsvData.DataSource = dt;
                dgvCsvData.Columns[0].ReadOnly = true;

                gbGrid.Width = dgvCsvData.Width;

                foreach (DataGridViewColumn column in dgvCsvData.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

            }

            tbRowCount.Text = formDt.Rows.Count.ToString();

        }


        private void ttBtImport_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ckbKeepLocation_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbKeepLocation.Checked == true)
            //    ofdCsvData.RestoreDirectory = true;
            //else
            //    ofdCsvData.RestoreDirectory = false;


        }

        private void gbGrid_Enter(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SearchAddress();
        }

        private void SearchAddress()
        {
            string searchTerm = tbSearchTerm.Text;
            bool found = false;
            foreach (DataGridViewRow row in dgvCsvData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                    {

                        cell.Selected = true;
                        row.Selected = true;
                        found = true;
                        cell.Style.BackColor = Color.Orange;


                    }
                }
            }
            if(!found)
            {

                MessageBox.Show(String.Format("Address -'{0}'- not Found", searchTerm));
                ClearSearchResults();
            }
              
        }

        private void ClearSearchResults()
        {
            dgvCsvData.ClearSelection();
           
            foreach (DataGridViewRow row in dgvCsvData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = SystemColors.Window;
                    //cell.Style.SelectionBackColor = SystemColors.Window;
                }
            }
        }

        private void tbSearchTerm_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchTerm.Text))
            {
                btSearch.Enabled = false;
                btSearch.BackColor = DefaultBackColor;
                Debug.WriteLine("Textbox is empty or null");
                ClearSearchResults();
            }
            else
            {
                if (formDt != null && formDt.Rows.Count > 0 && tbSearchTerm.Text.Length >= 3)
                {
                    btSearch.Enabled = true;
                    btSearch.BackColor = searchBtGreen;
                  
                    
                    //if(tbSearchTerm.Text.Length >= 3)
                    //{

                    //btSearch.Enabled = true;
                    //btSearch.BackColor = searchBtGreen;
                    //}

                    //Debug.WriteLine("Textbox is not empty or null, and DataTable has data");
                }
                else
                {
                    btSearch.Enabled = false;
                    btSearch.BackColor = DefaultBackColor;
                    Debug.WriteLine("Textbox is not empty or null, but DataTable is empty or null");
                }
            }
        }




        private void tbSearchTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(tbSearchTerm.Text.Length >= 3)
                {
                    gbSearch.Text = "Search:";
                    //gbSearch.ForeColor = SystemColors.ControlText;
                    gbSearch.ForeColor = DefaultForeColor;
                    SearchAddress();
                }
                else
                {
                    gbSearch.Text = "Enter at least 3 characters";
                    gbSearch.ForeColor = Color.Coral;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
