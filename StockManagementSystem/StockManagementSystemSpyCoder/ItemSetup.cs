using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemSpyCoder.Models;
using System.Data.SqlClient;

namespace StockManagementSystemSpyCoder
{
    public partial class ItemSetup : UserControl
    {
        Item item = new Item();
        string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database = StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;

        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetupSaveButton_Click(object sender, EventArgs e)
        {
            item.Name = itemNameTextBox.Text;
            item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);

            bool isExecute = save(item);
            if (isExecute)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not saved");
            }

            companyComboBox.Text = "";
        }

        private bool save(Item item)
        {
            bool issaved = false;

            try
            {

                //3
                sqlConnection = new SqlConnection(connectionString);
                //4
                string query = @"INSERT INTO Items (Name, CategoryId, CompanyId, ReorderLevel) VALUES ('" + item.Name + "'," + item.CategoryId + "," + item.CompanyId + ",'" + item.ReorderLevel + "')";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    //MessageBox.Show("Saved");
                    issaved = true;
                }
                else
                {
                    //MessageBox.Show("Not Saved");
                    issaved = false;
                }
                //8
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


            return issaved;

        }

        public int CategoryId { get; set; }

        public int CompanyId { get; set; }

        public int ReorderLevel { get; set; } 
    }
}
