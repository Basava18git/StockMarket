using System;
using Newtonsoft.Json;
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
using System.Threading;


namespace StockMarket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          

            pwd_input.Focus();
            
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            StocksWindow stocksWindow = new StocksWindow();
            try
            {
                if (pwd_input.Text == "9945706254")
                {
                    MessageBox.Show("Login Successful");

                    
                    stocksWindow.ShowDialog();
                    //

                }
                else
                {
                    MessageBox.Show("Invalid Password");
                    pwd_input.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (!stocksWindow.IsActive)
                {
                    this.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void pwd_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
