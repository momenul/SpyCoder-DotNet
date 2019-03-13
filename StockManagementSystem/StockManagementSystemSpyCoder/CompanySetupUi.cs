using System;
using System.CodeDom;
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
        Company company = new Company();
        SqlConnection sqlConnection;

        Connection connection = new Connection();

        public CompanySetupUi()
        {
            InitializeComponent();
            ShowData();
        }

        private void CompanySetupSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(companySetupNameTextBox.Text))
                {
                    errorLabel.Text = "Please enter the value.";
                    return;
                }
                company.Name = companySetupNameTextBox.Text;
                bool isSave = Add(company);
                if (isSave)
                {
                    MessageBox.Show("Saved");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }

                ShowData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowData()
        {
            
            DataTable dataTable = Getdata();
            companyDataGridView.DataSource = dataTable;
            companyDataGridView.Columns[1].Visible = false;    
            foreach (DataGridViewRow row in companyDataGridView.Rows)
            {
                row.Cells[0].Value = (row.Index + 1).ToString();
            }
            
        }

        private DataTable Getdata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection= new SqlConnection(connection.connectionString);
                string query = @"SELECT * FROM Companies";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                DataColumn col = dataTable.Columns.Add("SL", typeof(int));
                col.SetOrdinal(0);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;
        }

        private bool Add(Company company)
        {
            bool isSucces = false;
            try
            {
                sqlConnection= new SqlConnection(connection.connectionString);
                string query = @"INSERT INTO Companies (Name) VALUES ('" + company.Name + "')";
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

        private void companyDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.companyDataGridView.Rows[e.RowIndex];
                    companySetupNameTextBox.Text = row.Cells["Name"].Value.ToString();
                    companyIdTextBox.Text = row.Cells["Id"].Value.ToString();

                    CompanySetupSaveButton.Hide();
                    updateButton.Show();
                    errorLabel.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(companySetupNameTextBox.Text))
                {
                    errorLabel.Text = "Please enter the value.";
                    return;
                }
                company.Id = Convert.ToInt32(companyIdTextBox.Text);
                company.Name = companySetupNameTextBox.Text;
                bool isUpdate = Update(company);
                if (isUpdate)
                {
                    updateButton.Hide();
                    CompanySetupSaveButton.Show();
                    Clear();
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated.");
                }
                ShowData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool Update(Company company)
        {
            bool isSucces = false;
            sqlConnection = new SqlConnection(connection.connectionString);
            string query = @"update Companies set Name = '" + company.Name + "' where Id = " + company.Id + "";
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

            return isSucces;
        }

        public void Clear()
        {
            errorLabel.Text = "";
            companySetupNameTextBox.Text = "";
            companyIdTextBox.Text = "";
        }
    }
}
