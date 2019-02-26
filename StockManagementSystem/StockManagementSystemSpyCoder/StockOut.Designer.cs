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
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.avalibleQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StockOutAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOutSellButton = new System.Windows.Forms.Button();
            this.StockOutDamageButton = new System.Windows.Forms.Button();
            this.StockOutLostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(260, 10);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(186, 21);
            this.companyComboBox.TabIndex = 42;
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(260, 42);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(186, 21);
            this.itemComboBox.TabIndex = 41;
            // 
            // avalibleQuantityTextBox
            // 
            this.avalibleQuantityTextBox.Location = new System.Drawing.Point(260, 105);
            this.avalibleQuantityTextBox.Name = "avalibleQuantityTextBox";
            this.avalibleQuantityTextBox.Size = new System.Drawing.Size(186, 20);
            this.avalibleQuantityTextBox.TabIndex = 38;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(260, 136);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(186, 20);
            this.stockInQuantityTextBox.TabIndex = 39;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(260, 74);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(186, 20);
            this.reorderLevelTextBox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(208, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Avalible Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(183, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Stock In Quantity";
            // 
            // StockOutAddButton
            // 
            this.StockOutAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StockOutAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutAddButton.ForeColor = System.Drawing.Color.White;
            this.StockOutAddButton.Location = new System.Drawing.Point(361, 165);
            this.StockOutAddButton.Name = "StockOutAddButton";
            this.StockOutAddButton.Size = new System.Drawing.Size(85, 31);
            this.StockOutAddButton.TabIndex = 37;
            this.StockOutAddButton.Text = "Add";
            this.StockOutAddButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Reorder Level";
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Column1,
            this.Company,
            this.Column2});
            this.stockOutDataGridView.GridColor = System.Drawing.Color.White;
            this.stockOutDataGridView.Location = new System.Drawing.Point(61, 211);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.RowHeadersWidth = 31;
            this.stockOutDataGridView.Size = new System.Drawing.Size(525, 196);
            this.stockOutDataGridView.TabIndex = 43;
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
            this.Column1.Width = 130;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // StockOutSellButton
            // 
            this.StockOutSellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StockOutSellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutSellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutSellButton.ForeColor = System.Drawing.Color.White;
            this.StockOutSellButton.Location = new System.Drawing.Point(233, 413);
            this.StockOutSellButton.Name = "StockOutSellButton";
            this.StockOutSellButton.Size = new System.Drawing.Size(75, 32);
            this.StockOutSellButton.TabIndex = 44;
            this.StockOutSellButton.Text = "Sell";
            this.StockOutSellButton.UseVisualStyleBackColor = false;
            // 
            // StockOutDamageButton
            // 
            this.StockOutDamageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StockOutDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutDamageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutDamageButton.ForeColor = System.Drawing.Color.White;
            this.StockOutDamageButton.Location = new System.Drawing.Point(350, 413);
            this.StockOutDamageButton.Name = "StockOutDamageButton";
            this.StockOutDamageButton.Size = new System.Drawing.Size(75, 32);
            this.StockOutDamageButton.TabIndex = 45;
            this.StockOutDamageButton.Text = "Damage";
            this.StockOutDamageButton.UseVisualStyleBackColor = false;
            // 
            // StockOutLostButton
            // 
            this.StockOutLostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StockOutLostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockOutLostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutLostButton.ForeColor = System.Drawing.Color.White;
            this.StockOutLostButton.Location = new System.Drawing.Point(467, 413);
            this.StockOutLostButton.Name = "StockOutLostButton";
            this.StockOutLostButton.Size = new System.Drawing.Size(75, 32);
            this.StockOutLostButton.TabIndex = 46;
            this.StockOutLostButton.Text = "Lost";
            this.StockOutLostButton.UseVisualStyleBackColor = false;
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StockOutLostButton);
            this.Controls.Add(this.StockOutDamageButton);
            this.Controls.Add(this.StockOutSellButton);
            this.Controls.Add(this.stockOutDataGridView);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.avalibleQuantityTextBox);
            this.Controls.Add(this.stockInQuantityTextBox);
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

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.TextBox avalibleQuantityTextBox;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StockOutAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.Button StockOutSellButton;
        private System.Windows.Forms.Button StockOutDamageButton;
        private System.Windows.Forms.Button StockOutLostButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
