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
        Companie companie = new Companie();
        string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database = StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;

        public CompanySetupUi()
        {
            InitializeComponent();
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

            DataTable dataTable = Show();
            companyDataGridView.DataSource = dataTable;
        }
        private DataTable Show()
        {
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = new SqlConnection(connectionString);

                //4
                // string query = @"SELECT * FROM Companies";
                string query = @"SELECT Name FROM Companies";

                //5
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

        private bool Add(Companie companie)
        {
            bool isSucces = false;

            try
            {

                sqlConnection = new SqlConnection(connectionString);

                string query = @"INSERT INTO Companies (Name) VALUES ('" + companie.Name + "')";

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
    }
}
