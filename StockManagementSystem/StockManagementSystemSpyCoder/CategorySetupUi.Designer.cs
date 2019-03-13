namespace StockManagementSystemSpyCoder
{
    partial class CategorySetupUi
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
            this.categorySetupNameTextBox = new System.Windows.Forms.TextBox();
            this.categorySetupSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.categoryIdTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categorySetupNameTextBox
            // 
            this.categorySetupNameTextBox.Location = new System.Drawing.Point(228, 63);
            this.categorySetupNameTextBox.Name = "categorySetupNameTextBox";
            this.categorySetupNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.categorySetupNameTextBox.TabIndex = 29;
            // 
            // categorySetupSaveButton
            // 
            this.categorySetupSaveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.categorySetupSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorySetupSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySetupSaveButton.ForeColor = System.Drawing.Color.White;
            this.categorySetupSaveButton.Location = new System.Drawing.Point(399, 99);
            this.categorySetupSaveButton.Name = "categorySetupSaveButton";
            this.categorySetupSaveButton.Size = new System.Drawing.Size(90, 34);
            this.categorySetupSaveButton.TabIndex = 28;
            this.categorySetupSaveButton.Text = "Save";
            this.categorySetupSaveButton.UseVisualStyleBackColor = false;
            this.categorySetupSaveButton.Click += new System.EventHandler(this.categorySetupSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AllowUserToAddRows = false;
            this.categoriesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView.Location = new System.Drawing.Point(228, 181);
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.ReadOnly = true;
            this.categoriesGridView.Size = new System.Drawing.Size(261, 162);
            this.categoriesGridView.TabIndex = 30;
            this.categoriesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesGridView_CellDoubleClick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(225, 86);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 31;
            // 
            // categoryIdTextBox
            // 
            this.categoryIdTextBox.Location = new System.Drawing.Point(228, 26);
            this.categoryIdTextBox.Name = "categoryIdTextBox";
            this.categoryIdTextBox.Size = new System.Drawing.Size(27, 20);
            this.categoryIdTextBox.TabIndex = 32;
            this.categoryIdTextBox.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Linen;
            this.updateButton.Location = new System.Drawing.Point(399, 99);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 34);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // CategorySetupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.categoryIdTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.categoriesGridView);
            this.Controls.Add(this.categorySetupNameTextBox);
            this.Controls.Add(this.categorySetupSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "CategorySetupUi";
            this.Size = new System.Drawing.Size(589, 396);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox categorySetupNameTextBox;
        private System.Windows.Forms.Button categorySetupSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox categoryIdTextBox;
        private System.Windows.Forms.Button updateButton;
    }
}
