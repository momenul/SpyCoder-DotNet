namespace StockManagementSystemSpyCoder
{
    partial class SearchAndView
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
            this.searchAndViewDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchAndViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchAndViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchAndViewDataGridView
            // 
            this.searchAndViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchAndViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Company,
            this.Column2,
            this.AvailableQuantity,
            this.ReorderLevel});
            this.searchAndViewDataGridView.GridColor = System.Drawing.Color.White;
            this.searchAndViewDataGridView.Location = new System.Drawing.Point(16, 223);
            this.searchAndViewDataGridView.Name = "searchAndViewDataGridView";
            this.searchAndViewDataGridView.RowHeadersWidth = 31;
            this.searchAndViewDataGridView.Size = new System.Drawing.Size(562, 75);
            this.searchAndViewDataGridView.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.HeaderText = "Reorder Level";
            this.ReorderLevel.Name = "ReorderLevel";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(210, 32);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyComboBox.TabIndex = 61;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(210, 76);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(186, 21);
            this.categoryComboBox.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "Company";
            // 
            // SearchAndViewButton
            // 
            this.SearchAndViewButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchAndViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchAndViewButton.ForeColor = System.Drawing.Color.White;
            this.SearchAndViewButton.Location = new System.Drawing.Point(307, 145);
            this.SearchAndViewButton.Name = "SearchAndViewButton";
            this.SearchAndViewButton.Size = new System.Drawing.Size(89, 31);
            this.SearchAndViewButton.TabIndex = 56;
            this.SearchAndViewButton.Text = "Search";
            this.SearchAndViewButton.UseVisualStyleBackColor = false;
            // 
            // SearchAndView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchAndViewDataGridView);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchAndViewButton);
            this.Name = "SearchAndView";
            this.Size = new System.Drawing.Size(595, 442);
            ((System.ComponentModel.ISupportInitialize)(this.searchAndViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchAndViewDataGridView;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchAndViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
    }
}
