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
        private string connectionString = @"Server =DESKTOP-IQOQ25D\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;

        private Company company = new Company();
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
            sqlConnection = new SqlConnection(connectionString);

            string query = @"select * from Items where Id=" + item.Id + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                item.Name = sqlDataReader["Name"].ToString();
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
           

            return isError;
        }

        private void StockInSaveButton_Click(object sender, EventArgs e)
        {
          try {

             bool isValid = ValidationCheck();           

            item.Name = itemComboBox.Text;
            company.Name = companyComboBox.Text;

            stocksIn.Quantity = Convert.ToInt32(stockInQuantityTextBox.Text);
            stocksIn.ItemId = item.Id;
            stocksIn.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
            int availabelQuantity = Convert.ToInt32(avalibleQuantityTextBox.Text);
            item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);

            avalibleQuantityTextBox.Text = (Convert.ToInt32(avalibleQuantityTextBox.Text) +
                                              Convert.ToInt32(stockInQuantityTextBox.Text)).ToString();
            bool isSave = Add(stocksIn);

            if (isSave)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool Add(StocksIn stocksIn)
        {
            bool isSucces = false;

            try
            {
                sqlConnection = new SqlConnection(connectionString);

                string query = @"INSERT INTO StockIn (ItemId, Quantity) VALUES ( " + stocksIn.ItemId + "," + stocksIn.Quantity + ")";
                
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

                //8
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return isSucces;

        }

        private DataTable GetCompanyCombo()
        {
            //3
            sqlConnection = new SqlConnection(connectionString);

            //4
            string query = @"SELECT Id, Name FROM Companies";
           
            //5
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            //6
            sqlConnection.Open();


            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);


            //8
            sqlConnection.Close();

            return dataTable;
        }
        private DataTable GetItemsCombo(Item item)
        {
            //3
            sqlConnection = new SqlConnection(connectionString);

            //4
            string query = @"SELECT Id, Name FROM Items WHERE CompanyId=" + item.CompanyId + "";
            //5
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            //6
            sqlConnection.Open();


            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);


            //8
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
