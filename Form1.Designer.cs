
namespace CSVUpload
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpImport = new System.Windows.Forms.FlowLayoutPanel();
            this.btImportData = new System.Windows.Forms.Button();
            this.ckbKeepLocation = new System.Windows.Forms.CheckBox();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            this.dgvCsvData = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.ofdCsvData = new System.Windows.Forms.OpenFileDialog();
            this.ttBtImport = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.gbRecords = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbRowCount = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpImport.SuspendLayout();
            this.gbGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.gbRecords.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.40668F));
            this.tableLayoutPanel1.Controls.Add(this.flpImport, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.288824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.29317F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.27286F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flpImport
            // 
            this.flpImport.Controls.Add(this.btImportData);
            this.flpImport.Controls.Add(this.ckbKeepLocation);
            this.flpImport.Location = new System.Drawing.Point(3, 3);
            this.flpImport.Name = "flpImport";
            this.flpImport.Size = new System.Drawing.Size(224, 54);
            this.flpImport.TabIndex = 2;
            // 
            // btImportData
            // 
            this.btImportData.AutoSize = true;
            this.btImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btImportData.Cursor = System.Windows.Forms.Cursors.Default;
            this.btImportData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btImportData.Location = new System.Drawing.Point(3, 3);
            this.btImportData.Name = "btImportData";
            this.btImportData.Size = new System.Drawing.Size(72, 23);
            this.btImportData.TabIndex = 1;
            this.btImportData.Text = "Import Data";
            this.btImportData.UseVisualStyleBackColor = true;
            this.btImportData.Click += new System.EventHandler(this.btImportData_Click);
            // 
            // ckbKeepLocation
            // 
            this.ckbKeepLocation.AutoSize = true;
            this.ckbKeepLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ckbKeepLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.ckbKeepLocation.Location = new System.Drawing.Point(81, 3);
            this.ckbKeepLocation.Name = "ckbKeepLocation";
            this.ckbKeepLocation.Size = new System.Drawing.Size(133, 23);
            this.ckbKeepLocation.TabIndex = 2;
            this.ckbKeepLocation.Text = "Keep Current Directory";
            this.ckbKeepLocation.UseVisualStyleBackColor = true;
            this.ckbKeepLocation.CheckedChanged += new System.EventHandler(this.ckbKeepLocation_CheckedChanged);
            // 
            // gbGrid
            // 
            this.gbGrid.BackColor = System.Drawing.SystemColors.Control;
            this.gbGrid.Controls.Add(this.dgvCsvData);
            this.gbGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGrid.Location = new System.Drawing.Point(233, 67);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(782, 561);
            this.gbGrid.TabIndex = 5;
            this.gbGrid.TabStop = false;
            this.gbGrid.Text = "DR";
            this.gbGrid.Enter += new System.EventHandler(this.gbGrid_Enter);
            // 
            // dgvCsvData
            // 
            this.dgvCsvData.AllowUserToResizeColumns = false;
            this.dgvCsvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCsvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCsvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCsvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCsvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCsvData.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCsvData.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCsvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCsvData.Location = new System.Drawing.Point(3, 16);
            this.dgvCsvData.Name = "dgvCsvData";
            this.dgvCsvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCsvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvCsvData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCsvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCsvData.Size = new System.Drawing.Size(776, 542);
            this.dgvCsvData.TabIndex = 6;
            this.ttBtImport.SetToolTip(this.dgvCsvData, "This is it\r\n");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.btSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(233, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 58);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearchTerm.Location = new System.Drawing.Point(6, 19);
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(200, 20);
            this.tbSearchTerm.TabIndex = 3;
            this.tbSearchTerm.TextChanged += new System.EventHandler(this.tbSearchTerm_TextChanged);
            this.tbSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchTerm_KeyDown);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSearch.FlatAppearance.BorderSize = 4;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSearch.Location = new System.Drawing.Point(233, 11);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(37, 35);
            this.btSearch.TabIndex = 4;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // ofdCsvData
            // 
            this.ofdCsvData.Filter = "CSV Files (*.csv)|*.csv";
            this.ofdCsvData.InitialDirectory = "@\"C:\\\"";
            this.ofdCsvData.Title = "Import File";
            // 
            // ttBtImport
            // 
            this.ttBtImport.IsBalloon = true;
            this.ttBtImport.Popup += new System.Windows.Forms.PopupEventHandler(this.ttBtImport_Popup);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gbTotal);
            this.flowLayoutPanel2.Controls.Add(this.gbRecords);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(233, 634);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(782, 52);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.tbTotal);
            this.gbTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTotal.Location = new System.Drawing.Point(670, 3);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(109, 45);
            this.gbTotal.TabIndex = 0;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // gbRecords
            // 
            this.gbRecords.Controls.Add(this.tbRowCount);
            this.gbRecords.Location = new System.Drawing.Point(544, 3);
            this.gbRecords.Name = "gbRecords";
            this.gbRecords.Size = new System.Drawing.Size(120, 45);
            this.gbRecords.TabIndex = 0;
            this.gbRecords.TabStop = false;
            this.gbRecords.Text = "Records";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.Control;
            this.tbTotal.Location = new System.Drawing.Point(3, 16);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 0;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRowCount
            // 
            this.tbRowCount.BackColor = System.Drawing.SystemColors.Control;
            this.tbRowCount.Location = new System.Drawing.Point(3, 16);
            this.tbRowCount.Name = "tbRowCount";
            this.tbRowCount.Size = new System.Drawing.Size(100, 20);
            this.tbRowCount.TabIndex = 0;
            this.tbRowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.gbSearch);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(224, 51);
            this.flowLayoutPanel3.TabIndex = 5;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearchTerm);
            this.gbSearch.Location = new System.Drawing.Point(3, 3);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(212, 44);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search:";
            this.gbSearch.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "D/R Entry";
            this.ttBtImport.SetToolTip(this, "HEllo");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flpImport.ResumeLayout(false);
            this.flpImport.PerformLayout();
            this.gbGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.gbRecords.ResumeLayout(false);
            this.gbRecords.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btImportData;
        private System.Windows.Forms.DataGridView dgvCsvData;
        private System.Windows.Forms.OpenFileDialog ofdCsvData;
        private System.Windows.Forms.GroupBox gbGrid;
        private System.Windows.Forms.ToolTip ttBtImport;
        private System.Windows.Forms.CheckBox ckbKeepLocation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbSearchTerm;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.FlowLayoutPanel flpImport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.GroupBox gbRecords;
        private System.Windows.Forms.TextBox tbRowCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox gbSearch;
    }
}

