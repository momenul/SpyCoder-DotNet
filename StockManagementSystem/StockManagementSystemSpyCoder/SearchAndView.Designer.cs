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
            this.components = new System.ComponentModel.Container();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchAndViewButton = new System.Windows.Forms.Button();
            this.searchAndViewDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAndViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companieBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(289, 44);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyComboBox.TabIndex = 61;
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companieBindingSource
            // 
            this.companieBindingSource.DataSource = typeof(StockManagementSystemSpyCoder.Models.Company);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categorieBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(289, 88);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(186, 21);
            this.categoryComboBox.TabIndex = 60;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataSource = typeof(StockManagementSystemSpyCoder.Models.Category);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 47);
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
            this.SearchAndViewButton.Location = new System.Drawing.Point(386, 152);
            this.SearchAndViewButton.Name = "SearchAndViewButton";
            this.SearchAndViewButton.Size = new System.Drawing.Size(89, 36);
            this.SearchAndViewButton.TabIndex = 56;
            this.SearchAndViewButton.Text = "Search";
            this.SearchAndViewButton.UseVisualStyleBackColor = false;
            this.SearchAndViewButton.Click += new System.EventHandler(this.SearchAndViewButton_Click);
            // 
            // searchAndViewDataGridView
            // 
            this.searchAndViewDataGridView.AllowUserToAddRows = false;
            this.searchAndViewDataGridView.AllowUserToDeleteRows = false;
            this.searchAndViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchAndViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchAndViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL});
            this.searchAndViewDataGridView.Location = new System.Drawing.Point(49, 229);
            this.searchAndViewDataGridView.Name = "searchAndViewDataGridView";
            this.searchAndViewDataGridView.ReadOnly = true;
            this.searchAndViewDataGridView.Size = new System.Drawing.Size(602, 190);
            this.searchAndViewDataGridView.TabIndex = 62;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL.No";
            this.SL.Name = "SL";
            this.SL.Width = 40;
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
            this.Size = new System.Drawing.Size(663, 442);
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAndViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchAndViewButton;
        private System.Windows.Forms.BindingSource companieBindingSource;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private System.Windows.Forms.DataGridView searchAndViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
    }
}
