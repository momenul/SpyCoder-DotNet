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
        private Company company = new Company();
        Category category = new Category();
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
                    //string query = @"SELECT * FROM ViewsSearch WHERE Companie = '" + companySearch + "' and Categorie='" + categorySearch + "'";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    searchAndViewDataGridView.DataSource = dataTable;

                    foreach (DataGridViewRow row in searchAndViewDataGridView.Rows)
                        row.Cells["SL"].Value = (row.Index + 1).ToString();

                    /*  int cellNum = 0;
                     int rowNum = 0;
                    foreach (DataGridViewRow row in searchAndViewDataGridView.Rows)
                     {
                         cellNum = cellNum + 1;
                         searchAndViewDataGridView.Rows[rowNum].Cells[0].Value = cellNum;
                         rowNum = rowNum + 1;
                     } */

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

            sqlConnection = new SqlConnection(connectionString);

            string query = @"SELECT Id, Name FROM Companies";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdaapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdaapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
        private DataTable GetCategoryCombo()
        {

            sqlConnection = new SqlConnection(connectionString);

            string query = @"SELECT Id, Name FROM Categories";
           
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
            //item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            //string companySearch = companyComboBox.Text;
           // categoryComboBox.DataSource = GetCategoryData(category);
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           //string categorySearch = categoryComboBox.Text;
           // GetCategoryData(category);
           // GetItemData(item);
        }

       
    }
}
