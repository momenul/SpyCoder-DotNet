namespace StockManagementSystemSpyCoder
{
    partial class CompanySetupUi
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
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.companySetupNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanySetupSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Location = new System.Drawing.Point(243, 184);
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.Size = new System.Drawing.Size(247, 140);
            this.companyDataGridView.TabIndex = 32;
            // 
            // companySetupNameTextBox
            // 
            this.companySetupNameTextBox.Location = new System.Drawing.Point(212, 67);
            this.companySetupNameTextBox.Name = "companySetupNameTextBox";
            this.companySetupNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.companySetupNameTextBox.TabIndex = 31;
            // 
            // CompanySetupSaveButton
            // 
            this.CompanySetupSaveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CompanySetupSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanySetupSaveButton.ForeColor = System.Drawing.Color.White;
            this.CompanySetupSaveButton.Location = new System.Drawing.Point(395, 115);
            this.CompanySetupSaveButton.Name = "CompanySetupSaveButton";
            this.CompanySetupSaveButton.Size = new System.Drawing.Size(95, 29);
            this.CompanySetupSaveButton.TabIndex = 30;
            this.CompanySetupSaveButton.Text = "Save";
            this.CompanySetupSaveButton.UseVisualStyleBackColor = false;
            this.CompanySetupSaveButton.Click += new System.EventHandler(this.CompanySetupSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name";
            // 
            // CompanySetupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.companySetupNameTextBox);
            this.Controls.Add(this.CompanySetupSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "CompanySetupUi";
            this.Size = new System.Drawing.Size(556, 391);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.TextBox companySetupNameTextBox;
        private System.Windows.Forms.Button CompanySetupSaveButton;
        private System.Windows.Forms.Label label1;
    }
}
