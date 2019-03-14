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
        Connection connection = new Connection();
        private SqlConnection sqlConnection;
        public ItemSetup()
        {
            InitializeComponent();
            try
            {
                categoryComboBox.DataSource = Getcategorycombo();
                companyComboBox.DataSource = Getcompanycombox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isValitation()
        {
            bool isError = false;
            if (string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                errorItemLabel.Text = "Please enter the item name.";
                isError = true;
            }
            if (reorderLevelTextBox.Text == "")
            {
                errorReorderLabel.Text = "Please enter the value.";
                isError = true;
            }
            return isError;
        }

        public void Clear()
        {
            errorItemLabel.Text = "";
            errorReorderLabel.Text = "";
            itemNameTextBox.Text = "";
            reorderLevelTextBox.Text = "";
        }
        private void ItemSetupSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isTrue = isValitation();
                if (isTrue)
                {
                    return;
                }
                item.Name = itemNameTextBox.Text;
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                bool isExits = Exists(item);
                if (isExits)
                {
                    MessageBox.Show("This item already exits.");
                    return;
                }
                bool isExecute = save(item);
                if (isExecute)
                {
                    MessageBox.Show("Saved");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Not saved");
                } 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }          
        }

        private bool save(Item item)
        {
            bool issaved = false;
            sqlConnection= new SqlConnection(connection.connectionString);
            string query = @"INSERT INTO Items (Name, CategoryId, CompanyId, ReorderLevel) VALUES ('" + item.Name + "'," + item.CategoryId + "," + item.CompanyId + "," + item.ReorderLevel + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                issaved = true;
            }
            else
            {
                issaved = false;
            }
            sqlConnection.Close();
            
            return issaved;
        }

        private DataTable Getcategorycombo()
        {
            sqlConnection= new SqlConnection(connection.connectionString);
            string query = @"SELECT Id, Name FROM Categories";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        private DataTable Getcompanycombox()
        {
            sqlConnection= new SqlConnection(connection.connectionString);
            string query = @"SELECT Id, Name FROM Companies";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        private bool Exists(Item item)
        {
            bool isExists = false;
            sqlConnection = new SqlConnection(connection.connectionString);
            string query = @"SELECT * FROM Items WHERE Name ='" + item.Name + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isExists = true;
            }
            else
            {
                isExists = false;
            }
            sqlConnection.Close();
            return isExists;
        }

    }
}
