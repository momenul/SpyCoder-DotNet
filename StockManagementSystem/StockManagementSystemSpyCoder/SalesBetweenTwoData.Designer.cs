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
            this.toTateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesBetweenDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesBetweenTwoDataSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesBetweenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toTateTimePicker
            // 
            this.toTateTimePicker.Location = new System.Drawing.Point(280, 68);
            this.toTateTimePicker.Name = "toTateTimePicker";
            this.toTateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.toTateTimePicker.TabIndex = 82;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(280, 22);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.FromDateTimePicker.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "From Date";
            // 
            // salesBetweenDataGridView
            // 
            this.salesBetweenDataGridView.AllowUserToAddRows = false;
            this.salesBetweenDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.salesBetweenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesBetweenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL});
            this.salesBetweenDataGridView.GridColor = System.Drawing.Color.White;
            this.salesBetweenDataGridView.Location = new System.Drawing.Point(54, 166);
            this.salesBetweenDataGridView.Name = "salesBetweenDataGridView";
            this.salesBetweenDataGridView.ReadOnly = true;
            this.salesBetweenDataGridView.RowHeadersWidth = 31;
            this.salesBetweenDataGridView.Size = new System.Drawing.Size(443, 226);
            this.salesBetweenDataGridView.TabIndex = 78;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // SalesBetweenTwoDataSearchButton
            // 
            this.SalesBetweenTwoDataSearchButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalesBetweenTwoDataSearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesBetweenTwoDataSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesBetweenTwoDataSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBetweenTwoDataSearchButton.ForeColor = System.Drawing.Color.White;
            this.SalesBetweenTwoDataSearchButton.Location = new System.Drawing.Point(374, 112);
            this.SalesBetweenTwoDataSearchButton.Name = "SalesBetweenTwoDataSearchButton";
            this.SalesBetweenTwoDataSearchButton.Size = new System.Drawing.Size(86, 35);
            this.SalesBetweenTwoDataSearchButton.TabIndex = 77;
            this.SalesBetweenTwoDataSearchButton.Text = "Search";
            this.SalesBetweenTwoDataSearchButton.UseVisualStyleBackColor = false;
            this.SalesBetweenTwoDataSearchButton.Click += new System.EventHandler(this.SalesBetweenTwoDataSearchButton_Click_1);
            // 
            // SalesBetweenTwoData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toTateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesBetweenDataGridView);
            this.Controls.Add(this.SalesBetweenTwoDataSearchButton);
            this.Name = "SalesBetweenTwoData";
            this.Size = new System.Drawing.Size(550, 436);
            ((System.ComponentModel.ISupportInitialize)(this.salesBetweenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker toTateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salesBetweenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.Button SalesBetweenTwoDataSearchButton;

    }
}
