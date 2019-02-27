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
    public partial class SearchAndView : UserControl
    {
        Item item = new Item();
        string connectionString = @"Server =DESKTOP-IQOQ25D\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;

        public SearchAndView()
        {
            InitializeComponent();
            try
            {
                companyComboBox.DataSource = GetCompanyCombo();
                categoryComboBox.DataSource = GetCategoryCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchAndViewButton_Click(object sender, EventArgs e)
        {
            string companySearch = companyComboBox.Text;
            string categorySearch = categoryComboBox.Text;

            try
            {
                if (companySearch == "" || categorySearch == "")
                {
                    MessageBox.Show("Plase fill out field.");
                }

                else
                {

                    sqlConnection = new SqlConnection(connectionString);
                    string query = @"SELECT * FROM ViewItems WHERE Company = '" + companySearch + "' and Category='" + categorySearch + "'";
                  
                    //5
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    //6
                    sqlConnection.Open();
                    //7
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    searchAndViewDataGridView.DataSource = dataTable;
                   
                    companyComboBox.Text = "";
                    categoryComboBox.Text = "";

                    sqlConnection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
        private DataTable GetCategoryCombo()
        {
            //3
            sqlConnection = new SqlConnection(connectionString);

            //4
            string query = @"SELECT Id, Name FROM Categories";
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
    }
}
