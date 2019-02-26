namespace StockManagementSystemSpyCoder
{
    partial class SalesBetweenTwoData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salesBetweenDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateComboBox = new System.Windows.Forms.ComboBox();
            this.toDateComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalesBetweenTwoDataSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesBetweenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesBetweenDataGridView
            // 
            this.salesBetweenDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.salesBetweenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesBetweenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Column1,
            this.Company});
            this.salesBetweenDataGridView.GridColor = System.Drawing.Color.White;
            this.salesBetweenDataGridView.Location = new System.Drawing.Point(70, 174);
            this.salesBetweenDataGridView.Name = "salesBetweenDataGridView";
            this.salesBetweenDataGridView.RowHeadersWidth = 31;
            this.salesBetweenDataGridView.Size = new System.Drawing.Size(443, 226);
            this.salesBetweenDataGridView.TabIndex = 72;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Company
            // 
            this.Company.HeaderText = "Sale Quantity";
            this.Company.Name = "Company";
            this.Company.Width = 130;
            // 
            // fromDateComboBox
            // 
            this.fromDateComboBox.FormattingEnabled = true;
            this.fromDateComboBox.Location = new System.Drawing.Point(280, 31);
            this.fromDateComboBox.Name = "fromDateComboBox";
            this.fromDateComboBox.Size = new System.Drawing.Size(186, 21);
            this.fromDateComboBox.TabIndex = 71;
            // 
            // toDateComboBox
            // 
            this.toDateComboBox.FormattingEnabled = true;
            this.toDateComboBox.Location = new System.Drawing.Point(280, 75);
            this.toDateComboBox.Name = "toDateComboBox";
            this.toDateComboBox.Size = new System.Drawing.Size(186, 21);
            this.toDateComboBox.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 67;
            this.label4.Text = "To Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "From Date";
            // 
            // SalesBetweenTwoDataSearchButton
            // 
            this.SalesBetweenTwoDataSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SalesBetweenTwoDataSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBetweenTwoDataSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBetweenTwoDataSearchButton.ForeColor = System.Drawing.Color.White;
            this.SalesBetweenTwoDataSearchButton.Location = new System.Drawing.Point(380, 120);
            this.SalesBetweenTwoDataSearchButton.Name = "SalesBetweenTwoDataSearchButton";
            this.SalesBetweenTwoDataSearchButton.Size = new System.Drawing.Size(86, 32);
            this.SalesBetweenTwoDataSearchButton.TabIndex = 69;
            this.SalesBetweenTwoDataSearchButton.Text = "Search";
            this.SalesBetweenTwoDataSearchButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "To Date";
            // 
            // SalesBetweenTwoData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesBetweenDataGridView);
            this.Controls.Add(this.fromDateComboBox);
            this.Controls.Add(this.toDateComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalesBetweenTwoDataSearchButton);
            this.Name = "SalesBetweenTwoData";
            this.Size = new System.Drawing.Size(550, 414);
            ((System.ComponentModel.ISupportInitialize)(this.salesBetweenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesBetweenDataGridView;
        private System.Windows.Forms.ComboBox fromDateComboBox;
        private System.Windows.Forms.ComboBox toDateComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SalesBetweenTwoDataSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
