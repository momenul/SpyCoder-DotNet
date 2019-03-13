using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemSpyCoder.Models;

namespace StockManagementSystemSpyCoder
{
    public partial class StockOut : UserControl
    {
        Connection connection= new Connection();
        SqlConnection sqlConnection = new SqlConnection();
        private Item item = new Item();
        private Company company = new Company();
        private Stockout stockout = new Stockout();
        public StockOut()
        {
            InitializeComponent();
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            try
            {
                companyComboBox.DataSource = GetCompanyData();
            }
            catch (Exception expetion)
            {
                MessageBox.Show(expetion.Message);
            }
        }

        private DataTable GetCompanyData()
        {
            sqlConnection = new SqlConnection(connection.connectionString);

            string query = @"select Id, Name from Companies";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        private DataTable GetItemComboData(Item item)
        {
            sqlConnection = new SqlConnection(connection.connectionString);
            string query = @"select Id, Name from Items where CompanyId=" + item.CompanyId + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
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
                item.Name = sqlDataReader["Name"].ToString();
                item.ReorderLevel = Convert.ToInt32(sqlDataReader["ReorderLevel"]);
                item.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
            }
            sqlConnection.Close();
        }
        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                itemComboBox.DataSource = GetItemComboData(item);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            item.Id = Convert.ToInt32(itemComboBox.SelectedValue);
            GetItemData(item);
            reorderLevelTextBox.Text = item.ReorderLevel.ToString();
            avalibleQuantityTextBox.Text = item.Quantity.ToString();
        }
        private bool ValidationCheck()
        {
            bool isError = false;
            if (String.IsNullOrEmpty(stockOutQuantityTextBox.Text))
            {
                errorLabel.Text = "Please enter the value.";
                isError = true;
            }
            else if (Convert.ToInt32(stockOutQuantityTextBox.Text) > Convert.ToInt32(avalibleQuantityTextBox.Text))
            {
                errorLabel.Text = "Please enter less than " + avalibleQuantityTextBox.Text + "";
                isError = true;
            }

            else if (Convert.ToInt32(stockOutQuantityTextBox.Text) <= 0)
            {
                errorLabel.Text = "Please enter Positive value.";
                isError = true;
            }

            return isError;
        }

        private bool CheckReorder()
        {
            bool isReorder = false;
            if (Convert.ToInt32(avalibleQuantityTextBox.Text) < Convert.ToInt32(reorderLevelTextBox.Text))
            {
                isReorder = true;
            }
            return isReorder;
        }
        private void StockOutAddButton_Click_1(object sender, EventArgs e)
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
                item.Name = itemComboBox.Text;
                company.Name = companyComboBox.Text;
                stockout.Quantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
                stockout.ItemId = item.Id;
                int availabelQuantity = Convert.ToInt32(avalibleQuantityTextBox.Text);

                for (int i = 0; i < stockOutDataGridView.Rows.Count; i++)
                {
                    if (stockout.ItemId == Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[4].Value))
                    {
                        MessageBox.Show("Already add this item..");
                        return;
                    }                   
                }
                stockOutDataGridView.Rows.Add("",item.Name, company.Name, stockout.Quantity, item.Id, availabelQuantity);
                foreach (DataGridViewRow row in stockOutDataGridView.Rows)
                {
                    row.Cells[0].Value = (row.Index + 1).ToString();
                }
                avalibleQuantityTextBox.Text = (Convert.ToInt32(avalibleQuantityTextBox.Text) -
                                               Convert.ToInt32(stockOutQuantityTextBox.Text)).ToString();
                bool isReorder = CheckReorder();
                if (isReorder)
                {
                    MessageBox.Show("Please reorder this item.");
                }
                stockOutQuantityTextBox.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool IsertStockOutData(Stockout stockout)
        {
            bool isSuccess = false;
            sqlConnection = new SqlConnection(connection.connectionString);
            for (int i = 0; i < stockOutDataGridView.Rows.Count; i++)
            {
                stockout.ItemId = Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[4].Value);
                stockout.Quantity = Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[3].Value);
                int updateQuantity = (Convert.ToInt32(stockOutDataGridView.Rows[i].Cells[5].Value)) - stockout.Quantity;
                string query = @"insert into StockOut (ItemId, Quantity, Type) values (" + stockout.ItemId + ", " + stockout.Quantity + ", '" + stockout.Type + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                string updateQuery = @"UPDATE Items SET Quantity = " + updateQuantity + " where Id= " + stockout.ItemId + "";
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
            }
            return isSuccess;
        }
        private void DataGridViewClear()
        {
            stockOutDataGridView.Rows.Clear();
        }
        private void StockOutSellButton_Click(object sender, EventArgs e)
        {
            try
            {
                stockout.Type = "Sell";
                bool isSave = IsertStockOutData(stockout);
                if (isSave)
                {
                    MessageBox.Show("Saved.");
                }
                else
                {
                    MessageBox.Show("Not Saved.");
                }
                DataGridViewClear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void StockOutDamageButton_Click(object sender, EventArgs e)
        {
            try
            {
                stockout.Type = "Damage";
                bool isSave = IsertStockOutData(stockout);
                if (isSave)
                {
                    MessageBox.Show("Saved.");
                }
                else
                {
                    MessageBox.Show("Not Saved.");
                }
                DataGridViewClear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void StockOutLostButton_Click(object sender, EventArgs e)
        {
            try
            {
                stockout.Type = "Lost";
                bool isSave = IsertStockOutData(stockout);
                if (isSave)
                {
                    MessageBox.Show("Saved.");
                }
                else
                {
                    MessageBox.Show("Not Saved.");
                }
                DataGridViewClear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void stockOutDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int rowIndex = stockOutDataGridView.CurrentCell.RowIndex;
                    stockOutDataGridView.Rows.RemoveAt(rowIndex);
                    avalibleQuantityTextBox.Text = item.Quantity.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }    
    }
}
