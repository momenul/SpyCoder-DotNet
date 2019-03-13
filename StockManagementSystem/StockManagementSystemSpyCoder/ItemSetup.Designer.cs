namespace StockManagementSystemSpyCoder
{
    partial class ItemSetup
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
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.ItemSetupSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.errorItemLabel = new System.Windows.Forms.Label();
            this.errorReorderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(293, 217);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(186, 20);
            this.reorderLevelTextBox.TabIndex = 12;
            // 
            // ItemSetupSaveButton
            // 
            this.ItemSetupSaveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ItemSetupSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemSetupSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSetupSaveButton.ForeColor = System.Drawing.Color.White;
            this.ItemSetupSaveButton.Location = new System.Drawing.Point(389, 286);
            this.ItemSetupSaveButton.Name = "ItemSetupSaveButton";
            this.ItemSetupSaveButton.Size = new System.Drawing.Size(90, 36);
            this.ItemSetupSaveButton.TabIndex = 11;
            this.ItemSetupSaveButton.Text = "Save";
            this.ItemSetupSaveButton.UseVisualStyleBackColor = false;
            this.ItemSetupSaveButton.Click += new System.EventHandler(this.ItemSetupSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reorder Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(293, 166);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.itemNameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(293, 124);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyComboBox.TabIndex = 60;
            this.companyComboBox.ValueMember = "Id";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AllowDrop = true;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(293, 77);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(186, 21);
            this.categoryComboBox.TabIndex = 61;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // errorItemLabel
            // 
            this.errorItemLabel.AutoSize = true;
            this.errorItemLabel.ForeColor = System.Drawing.Color.Red;
            this.errorItemLabel.Location = new System.Drawing.Point(290, 189);
            this.errorItemLabel.Name = "errorItemLabel";
            this.errorItemLabel.Size = new System.Drawing.Size(0, 13);
            this.errorItemLabel.TabIndex = 62;
            // 
            // errorReorderLabel
            // 
            this.errorReorderLabel.AutoSize = true;
            this.errorReorderLabel.ForeColor = System.Drawing.Color.Red;
            this.errorReorderLabel.Location = new System.Drawing.Point(290, 240);
            this.errorReorderLabel.Name = "errorReorderLabel";
            this.errorReorderLabel.Size = new System.Drawing.Size(0, 13);
            this.errorReorderLabel.TabIndex = 62;
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorReorderLabel);
            this.Controls.Add(this.errorItemLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemSetupSaveButton);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetup";
            this.Size = new System.Drawing.Size(598, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Button ItemSetupSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label errorItemLabel;
        private System.Windows.Forms.Label errorReorderLabel;

    }
}
