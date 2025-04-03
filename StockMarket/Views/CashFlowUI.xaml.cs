using StockMarket.APICalls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockMarket.Views
{
    /// <summary>
    /// Interaction logic for CashFlowUI.xaml
    /// </summary>
    public partial class CashFlowUI : UserControl
    {
        public CashFlowUI()
        {
            InitializeComponent();
            Method();
        }

        public async void Method()
        {
            APICall apiCall = new APICall();
            var stockinfo = await apiCall.GetCashFLow("MSFT");
            if (stockinfo != null)
            {
                NetIncome.Text = stockinfo.netincome;
                Reporeted_Cuurency.Text = stockinfo.reportedcurrency;
                Fiscal_year.Text = stockinfo.dateEnding;
            }
            else
            {
                MessageBox.Show("Invalid Symbol");
            }
        }
    }
}
