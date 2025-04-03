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
    /// Interaction logic for GetStockPriceUI.xaml
    /// </summary>
    public partial class GetStockPriceUI : UserControl
    {
        public GetStockPriceUI()
        {
            InitializeComponent();
            call();

        }

        public async void call()
        {
            APICall apiCall = new APICall();
            var stockinfo = await apiCall.GetStockPrice("MSFT");
            // StockInfo s = new StockInfo();
            if (stockinfo != null)
            {
                Price.Text = stockinfo.price;
                Last_Trade_price.Text = stockinfo.lastprice;
                Symbol_.Text = stockinfo.symbol;
            }
            else
            {
                MessageBox.Show("Invalid Symbol");
            }

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new StocksPage();  
            

        }
    }
}
