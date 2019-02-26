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

        Categorie categorie = new Categorie();
        string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database = StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;

        public CategorySetupUi()
        {
            InitializeComponent();
        }

        private void categorySetupSaveButton_Click(object sender, EventArgs e)
        {
            categorie.Name = categorySetupNameTextBox.Text;

            bool isSave = Add(categorie);

            if (isSave)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            DataTable dataTable = Show();
            categoriesGridView.DataSource = dataTable;
        }
        private DataTable Show()
        {
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = new SqlConnection(connectionString);

                //4
                // string query = @"SELECT * FROM Categories";
                string query = @"SELECT Name FROM Categories";
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

        private bool Add(Categorie categorie)
        {
            bool isSucces = false;

            try
            {

                sqlConnection = new SqlConnection(connectionString);

                // SqlConnection sqlConnection = new SqlConnection(connectionString);
                string query = @"INSERT INTO Categories (Name) VALUES ('" + categorie.Name + "')";

                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    //MessageBox.Show("Saved");
                    isSucces = true;
                }
                else
                {
                    //MessageBox.Show("Not Saved");
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
