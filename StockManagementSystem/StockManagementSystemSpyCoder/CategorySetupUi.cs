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
    public partial class CategorySetupUi : UserControl
    {
        Category category = new Category();
        Connection connection = new Connection();
        private SqlConnection sqlConnection;

        public CategorySetupUi()
        {
            InitializeComponent();
            GridShowData();           
        }

        private void categorySetupSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                category.Name = categorySetupNameTextBox.Text;
                bool isExits = Exists(category);
                if (isExits)
                {
                    MessageBox.Show("This name already exits.");
                    return;
                }
                if (string.IsNullOrEmpty(categorySetupNameTextBox.Text))
                {
                    errorLabel.Text = "Please enter the value.";
                    return;
                }

                bool isSave = Add(category);

                if (isSave)
                {
                    MessageBox.Show("Saved");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }

                GridShowData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GridShowData()
        {
            DataTable dataTable = GetData();
            categoriesGridView.DataSource = dataTable;
            categoriesGridView.Columns[1].Visible = false;          
            foreach (DataGridViewRow row in categoriesGridView.Rows)
            {
                row.Cells[0].Value = (row.Index + 1).ToString();             
            }
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection= new SqlConnection(connection.connectionString);
                string query = @"SELECT * FROM Categories";
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

        private bool Add(Category categorie)
        {
            bool isSucces = false;

            try
            {
                sqlConnection= new SqlConnection(connection.connectionString);
                string query = @"INSERT INTO Categories (Name) VALUES ('" + categorie.Name + "')";
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

        private void categoriesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.categoriesGridView.Rows[e.RowIndex];
                    categorySetupNameTextBox.Text = row.Cells["Name"].Value.ToString();
                    categoryIdTextBox.Text = row.Cells["Id"].Value.ToString();

                    categorySetupSaveButton.Hide();
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
                if (string.IsNullOrEmpty(categorySetupNameTextBox.Text))
                {
                    errorLabel.Text = "Please enter the value.";
                    return;
                }
                category.Id = Convert.ToInt32(categoryIdTextBox.Text);
                category.Name = categorySetupNameTextBox.Text;
                bool isUpdate = Update(category);
                if (isUpdate)
                {
                    updateButton.Hide();
                    categorySetupSaveButton.Show();
                    Clear();
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated.");
                }
                GridShowData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
        private bool Update(Category category)
        {
            bool isSucces = false;         
            sqlConnection = new SqlConnection(connection.connectionString);
            string query = @"update Categories set Name = '"+ category.Name +"' where Id = "+ category.Id +"";
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
            categorySetupNameTextBox.Text = "";
            categoryIdTextBox.Text = "";
        }
        private bool Exists(Category category)
        {
            bool isExists = false;
            sqlConnection = new SqlConnection(connection.connectionString);
            string query = @"SELECT * FROM Categories WHERE Name ='" + category.Name + "'";
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
