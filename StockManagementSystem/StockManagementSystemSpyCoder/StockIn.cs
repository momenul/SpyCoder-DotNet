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
    public partial class StockIn : UserControl
    {
        Connection connection= new Connection();
        SqlConnection sqlConnection= new SqlConnection();

        private Item item = new Item();
        private StocksIn stocksIn = new StocksIn();

        public StockIn()
        {
            InitializeComponent();
            try
            {
                companyComboBox.DataSource = GetCompanyCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetItemData(Item item)
        {
            sqlConnection = new SqlConnection(connection.connectionString);

            string query = @"select * from Items where Id=" + item.Id + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                item.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                item.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
            }
            sqlConnection.Close();
        }
        private bool ValidationCheck()
        {
            bool isError = false;
            if (String.IsNullOrEmpty(stockInQuantityTextBox.Text))
            {
                errorLabel.Text = "Please enter the value.";
                isError = true;
            }
            else if (Convert.ToInt32(stockInQuantityTextBox.Text) <= 0)
            {
                errorLabel.Text = "Please enter Positive value.";
                isError = true;
            }

            return isError;
        }

        private void StockInSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = ValidationCheck();

                if (isValid)
                {
                    return;
                }

                else
                {
                    errorLabel.Text = "";
                }

                stocksIn.Quantity = Convert.ToInt32(stockInQuantityTextBox.Text);
                stocksIn.ItemId = item.Id;
               
                bool isSave = IsertStockInData(stocksIn);
                if (isSave)
                {
                    MessageBox.Show("Successful Stock In");
                }
                else
                {
                    MessageBox.Show("Quantity Not Saved");
                }

                avalibleQuantityTextBox.Text = (Convert.ToInt32(avalibleQuantityTextBox.Text) +
                                                  Convert.ToInt32(stockInQuantityTextBox.Text)).ToString();
                stockInQuantityTextBox.Text = "";                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
     
        private bool IsertStockInData(StocksIn stocksIn)
        {
            bool isSuccess = false;
            sqlConnection = new SqlConnection(connection.connectionString);

            int updateQuantity = (Convert.ToInt32(avalibleQuantityTextBox.Text)) + stocksIn.Quantity;

            string query = @"insert into StockIn (ItemId, Quantity) values (" + stocksIn.ItemId + ", " + stocksIn.Quantity + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            string updateQuery = @"UPDATE Items SET Quantity = " + updateQuantity + " where Id= " + stocksIn.ItemId + "";
            SqlCommand sqlCommandUpdate = new SqlCommand(updateQuery, sqlConnection);
            sqlConnection.Open();

            int isExecuted = sqlCommand.ExecuteNonQuery();
            int isUpdateExecuted = sqlCommandUpdate.ExecuteNonQuery();
            if (isExecuted > 0 && isUpdateExecuted > 0)
            {
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }
            sqlConnection.Close();
           
            return isSuccess;
        }
        private DataTable GetCompanyCombo()
        {
            sqlConnection = new SqlConnection(connection.connectionString);
            string query = @"SELECT Id, Name FROM Companies";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        private DataTable GetItemsCombo(Item item)
        {
            sqlConnection = new SqlConnection(connection.connectionString);

            string query = @"SELECT Id, Name FROM Items WHERE CompanyId=" + item.CompanyId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            itemComboBox.DataSource = GetItemsCombo(item);
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            item.Id = Convert.ToInt32(itemComboBox.SelectedValue);
            GetItemData(item);
            reorderLevelTextBox.Text = item.ReorderLevel.ToString();
            avalibleQuantityTextBox.Text = item.Quantity.ToString();
        }
    }
}
