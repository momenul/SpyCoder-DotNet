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
    public partial class CompanySetupUi : UserControl
    {
        Company companie = new Company();

        string connectionString = @"Server =DESKTOP-IQOQ25D\SQLEXPRESS; Database = StockManagementSystem; Integrated Security = true ";

        private SqlConnection sqlConnection;

        public CompanySetupUi()
        {
            InitializeComponent();
            ShowData();
        }

        private void CompanySetupSaveButton_Click(object sender, EventArgs e)
        {
            companie.Name = companySetupNameTextBox.Text;

            bool isSave = Add(companie);

            if (isSave)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            ShowData();
        }

        private void ShowData()
        {
            DataTable dataTable = Getdata();
            companyDataGridView.DataSource = dataTable;
            foreach (DataGridViewRow row in companyDataGridView.Rows)
            {
                row.Cells["SL"].Value = (row.Index + 1).ToString();
            }
        }

        private DataTable Getdata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = @"SELECT Name FROM Companies";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;
        }

        private bool Add(Company companie)
        {
            bool isSucces = false;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                string query = @"INSERT INTO Companies (Name) VALUES ('" + companie.Name + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return isSucces;

        }
    }
}
