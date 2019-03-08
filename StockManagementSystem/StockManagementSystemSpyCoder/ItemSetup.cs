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

            itemNameTextBox.Text = "";
            reorderLevelTextBox.Text = "";
        }

        private bool save(Item item)
        {
            bool issaved = false;

            try
            {
                sqlConnection= new SqlConnection(connection.connectionString);
                string query = @"INSERT INTO Items (Name, CategoryId, CompanyId, ReorderLevel) VALUES ('" + item.Name + "'," + item.CategoryId + "," + item.CompanyId + "," + item.ReorderLevel + ")";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    issaved = true;
                }
                else
                {
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

        private DataTable Getcategorycombo()
        {
            sqlConnection= new SqlConnection(connection.connectionString);
            string query = @"SELECT Id, Name FROM Categories";

            //5
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            //6
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

            //5
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            //6
            sqlConnection.Open();


            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }


    }
}
