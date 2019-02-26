using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemSpyCoder
{
    public partial class HomeUi : Form
    {
        public HomeUi()
        {
            InitializeComponent();
            hoverPanel.Height = StockOutButton.Height;
            hoverPanel.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = StockOutButton.Height;
            hoverPanel.Top = StockOutButton.Top;
            stockOutPanal.BringToFront();
        }

        private void ViewSalesButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = ViewSalesButton.Height;
            hoverPanel.Top = ViewSalesButton.Top;
            salesBetweenTwoDataPanal.BringToFront();
        }

        private void SetupCategoryButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = SetupCategoryButton.Height;
            hoverPanel.Top = SetupCategoryButton.Top;
            categorySetupPanel.BringToFront();
        }

        private void SetupCompanyButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = SetupCompanyButton.Height;
            hoverPanel.Top = SetupCompanyButton.Top;
            companySetupNewPanel.BringToFront();
        }

        private void SetupItemButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = SetupItemButton.Height;
            hoverPanel.Top = SetupItemButton.Top;
            itemSetupPanal.BringToFront();
        }

        private void StockInButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = StockInButton.Height;
            hoverPanel.Top = StockInButton.Top;
            stockInPanal.BringToFront();  
        }

        private void SearchViewItemsButton_Click(object sender, EventArgs e)
        {
            hoverPanel.Height = SearchViewItemsButton.Height;
            hoverPanel.Top = SearchViewItemsButton.Top;
            searchAndViewPanal.BringToFront();
        }

  
        
    }
}
