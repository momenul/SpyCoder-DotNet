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

namespace StockManagementSystemSpyCoder
{
    public partial class SalesBetweenTwoData : UserControl
    {
        string connectionString = @"Server=DESKTOP-IQOQ25D\SQLEXPRESS; Database=StockManagementSystem; Integrated Security = true ";

        SqlConnection sqlConnection = new SqlConnection();

        public SalesBetweenTwoData()
        {
            InitializeComponent();
        }

        private void SalesBetweenTwoDataSearchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = GetSellData();
                salesBetweenDataGridView.DataSource = dataTable;
                foreach (DataGridViewRow row in salesBetweenDataGridView.Rows)
                {
                    row.Cells["SL"].Value = (row.Index + 1).ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
                
        }

        private DataTable GetSellData()
        {
            DataTable dataTable = new DataTable();
            string fromDate = FromDateTimePicker.Value.ToShortDateString();
            string toDate = toTateTimePicker.Value.ToString();

            sqlConnection = new SqlConnection(connectionString);
            //string query = @"select StockOut.Id, Items.Name as Item, StockOut.StockOutDate, StockOut.Quantity as 'Sell Quantity' from StockOut inner join Items on StockOut.ItemId=Items.Id where StockOut.StockOutDate BETWEEN '" + fromDate + "' and '" + toDate + "' and StockOut.Type='Sell'";
            string query = @"select Item, Quantity from SellDataView where StockOutDate BETWEEN '" + fromDate + "' and '" + toDate + "' and Type='Sell'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
