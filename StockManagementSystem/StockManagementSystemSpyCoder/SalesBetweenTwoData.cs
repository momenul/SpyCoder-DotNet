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
    public partial class SalesBetweenTwoData : UserControl
    {
        Connection connection= new Connection();

        public SalesBetweenTwoData()
        {
            InitializeComponent();
        }

        private void SalesBetweenTwoDataSearchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fromDate = FromDateTimePicker.Value.ToShortDateString();
                string toDate = toTateTimePicker.Value.ToShortDateString();

                DataTable dataTable = GetSellData(fromDate, toDate);
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

        private DataTable GetSellData(string fromDate, string toDate)
        {
            DataTable dataTable = new DataTable();           
            //string query = @"select StockOut.Id, Items.Name as Item, StockOut.StockOutDate, StockOut.Quantity as 'Sell Quantity' from StockOut inner join Items on StockOut.ItemId=Items.Id where StockOut.StockOutDate BETWEEN '" + fromDate + "' and '" + toDate + "' and StockOut.Type='Sell'";
            string query = @"select Item, Quantity from SellDataView where StockOutDate BETWEEN '" + fromDate + "' and '" + toDate + "' and Type='Sell'";
            SqlCommand sqlCommand = new SqlCommand(query, connection.sqlConnection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
