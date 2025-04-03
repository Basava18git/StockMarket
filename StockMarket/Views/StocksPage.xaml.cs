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
using StockMarket.APICalls;
using static StockMarket.Views.CashFlowUI;


namespace StockMarket.Views
{
    /// <summary>
    /// Interaction logic for StocksPage.xaml
    /// </summary>
    public partial class StocksPage : UserControl
    {
        public StocksPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click_CashFlow(object sender, RoutedEventArgs e)
        {
            mainContent.Content = new StockMarket.Views.CashFlowUI();
        }

        private void Button_Click_StockPrice(object sender, RoutedEventArgs e)
        {
            mainContent.Content=new StockMarket.Views.GetStockPriceUI();
        }

        
    }
}
