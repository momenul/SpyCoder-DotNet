namespace StockManagementSystemSpyCoder
{
    partial class StockOut
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutLostButton = new System.Windows.Forms.Button();
            this.StockOutDamageButton = new System.Windows.Forms.Button();
            this.StockOutSellButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.avalibleQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StockOutAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(456, 140);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 64;
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.AllowUserToAddRows = false;
            this.stockOutDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.stockOutDataGridView.Location = new System.Drawing.Point(38, 219);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.ReadOnly = true;
            this.stockOutDataGridView.Size = new System.Drawing.Size(523, 190);
            this.stockOutDataGridView.TabIndex = 63;
            this.stockOutDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockOutDataGridView_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SL";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Company";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ItemId";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Avalible Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // StockOutLostButton
            // 
            this.StockOutLostButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StockOutLostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutLostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutLostButton.ForeColor = System.Drawing.Color.White;
            this.StockOutLostButton.Location = new System.Drawing.Point(459, 415);
            this.StockOutLostButton.Name = "StockOutLostButton";
            this.StockOutLostButton.Size = new System.Drawing.Size(75, 32);
            this.StockOutLostButton.TabIndex = 62;
            this.StockOutLostButton.Text = "Lost";
            this.StockOutLostButton.UseVisualStyleBackColor = false;
            this.StockOutLostButton.Click += new System.EventHandler(this.StockOutLostButton_Click);
            // 
            // StockOutDamageButton
            // 
            this.StockOutDamageButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StockOutDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutDamageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutDamageButton.ForeColor = System.Drawing.Color.White;
            this.StockOutDamageButton.Location = new System.Drawing.Point(342, 415);
            this.StockOutDamageButton.Name = "StockOutDamageButton";
            this.StockOutDamageButton.Size = new System.Drawing.Size(75, 32);
            this.StockOutDamageButton.TabIndex = 61;
            this.StockOutDamageButton.Text = "Damage";
            this.StockOutDamageButton.UseVisualStyleBackColor = false;
            this.StockOutDamageButton.Click += new System.EventHandler(this.StockOutDamageButton_Click);
            // 
            // StockOutSellButton
            // 
            this.StockOutSellButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StockOutSellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutSellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutSellButton.ForeColor = System.Drawing.Color.White;
            this.StockOutSellButton.Location = new System.Drawing.Point(225, 415);
            this.StockOutSellButton.Name = "StockOutSellButton";
            this.StockOutSellButton.Size = new System.Drawing.Size(75, 32);
            this.StockOutSellButton.TabIndex = 60;
            this.StockOutSellButton.Text = "Sell";
            this.StockOutSellButton.UseVisualStyleBackColor = false;
            this.StockOutSellButton.Click += new System.EventHandler(this.StockOutSellButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(252, 12);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyComboBox.TabIndex = 59;
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // itemComboBox
            // 
            this.itemComboBox.AllowDrop = true;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(252, 44);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(186, 21);
            this.itemComboBox.TabIndex = 58;
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // avalibleQuantityTextBox
            // 
            this.avalibleQuantityTextBox.Location = new System.Drawing.Point(252, 107);
            this.avalibleQuantityTextBox.Name = "avalibleQuantityTextBox";
            this.avalibleQuantityTextBox.ReadOnly = true;
            this.avalibleQuantityTextBox.Size = new System.Drawing.Size(186, 20);
            this.avalibleQuantityTextBox.TabIndex = 55;
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(252, 138);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(186, 20);
            this.stockOutQuantityTextBox.TabIndex = 56;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(252, 76);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.ReadOnly = true;
            this.reorderLevelTextBox.Size = new System.Drawing.Size(186, 20);
            this.reorderLevelTextBox.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(200, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Avalible Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(175, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Stock Out Quantity";
            // 
            // StockOutAddButton
            // 
            this.StockOutAddButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StockOutAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutAddButton.ForeColor = System.Drawing.Color.White;
            this.StockOutAddButton.Location = new System.Drawing.Point(353, 167);
            this.StockOutAddButton.Name = "StockOutAddButton";
            this.StockOutAddButton.Size = new System.Drawing.Size(85, 31);
            this.StockOutAddButton.TabIndex = 54;
            this.StockOutAddButton.Text = "Add";
            this.StockOutAddButton.UseVisualStyleBackColor = false;
            this.StockOutAddButton.Click += new System.EventHandler(this.StockOutAddButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Reorder Level";
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.stockOutDataGridView);
            this.Controls.Add(this.StockOutLostButton);
            this.Controls.Add(this.StockOutDamageButton);
            this.Controls.Add(this.StockOutSellButton);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.avalibleQuantityTextBox);
            this.Controls.Add(this.stockOutQuantityTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StockOutAddButton);
            this.Controls.Add(this.label1);
            this.Name = "StockOut";
            this.Size = new System.Drawing.Size(598, 459);
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.Button StockOutLostButton;
        private System.Windows.Forms.Button StockOutDamageButton;
        private System.Windows.Forms.Button StockOutSellButton;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.TextBox avalibleQuantityTextBox;
        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StockOutAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}
