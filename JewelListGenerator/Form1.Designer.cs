namespace JewelListGenerator
{
    partial class MainForm
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
            this.btnRunJewel = new System.Windows.Forms.Button();
            this.txtBoxDirectoryInput = new System.Windows.Forms.TextBox();
            this.txtBoxSearchString = new System.Windows.Forms.TextBox();
            this.checkBoxListJewels = new System.Windows.Forms.CheckBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileLineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunJewel
            // 
            this.btnRunJewel.Location = new System.Drawing.Point(13, 76);
            this.btnRunJewel.Name = "btnRunJewel";
            this.btnRunJewel.Size = new System.Drawing.Size(91, 35);
            this.btnRunJewel.TabIndex = 1;
            this.btnRunJewel.Text = "Run";
            this.btnRunJewel.UseVisualStyleBackColor = true;
            this.btnRunJewel.Click += new System.EventHandler(this.btnRunJewel_Click);
            // 
            // txtBoxDirectoryInput
            // 
            this.txtBoxDirectoryInput.Location = new System.Drawing.Point(13, 12);
            this.txtBoxDirectoryInput.Name = "txtBoxDirectoryInput";
            this.txtBoxDirectoryInput.Size = new System.Drawing.Size(249, 26);
            this.txtBoxDirectoryInput.TabIndex = 2;
            this.txtBoxDirectoryInput.Text = "Root directory";
            // 
            // txtBoxSearchString
            // 
            this.txtBoxSearchString.Location = new System.Drawing.Point(13, 44);
            this.txtBoxSearchString.Name = "txtBoxSearchString";
            this.txtBoxSearchString.Size = new System.Drawing.Size(249, 26);
            this.txtBoxSearchString.TabIndex = 3;
            this.txtBoxSearchString.Text = "String to match";
            // 
            // checkBoxListJewels
            // 
            this.checkBoxListJewels.AutoSize = true;
            this.checkBoxListJewels.Location = new System.Drawing.Point(110, 82);
            this.checkBoxListJewels.Name = "checkBoxListJewels";
            this.checkBoxListJewels.Size = new System.Drawing.Size(121, 24);
            this.checkBoxListJewels.TabIndex = 4;
            this.checkBoxListJewels.Text = "List Jewels?";
            this.checkBoxListJewels.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileLineNumber});
            this.dataGridView.Location = new System.Drawing.Point(13, 117);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(754, 514);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            // 
            // FileLineNumber
            // 
            this.FileLineNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileLineNumber.HeaderText = "Line Number";
            this.FileLineNumber.Name = "FileLineNumber";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(611, 72);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(141, 34);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export .CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 653);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.checkBoxListJewels);
            this.Controls.Add(this.txtBoxSearchString);
            this.Controls.Add(this.txtBoxDirectoryInput);
            this.Controls.Add(this.btnRunJewel);
            this.Name = "MainForm";
            this.Text = "Jewel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRunJewel;
        private System.Windows.Forms.TextBox txtBoxDirectoryInput;
        private System.Windows.Forms.TextBox txtBoxSearchString;
        private System.Windows.Forms.CheckBox checkBoxListJewels;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileLineNumber;
        private System.Windows.Forms.Button btnExport;
    }
}

