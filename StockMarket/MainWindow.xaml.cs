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
            MainWindow mainWindow = new MainWindow();
            StocksWindow stocksWindow = new StocksWindow();
            try
            {
                if (pwd_input.Text == "9945706254")
                {
                    MessageBox.Show("Login Successful");

                    
                    stocksWindow.ShowDialog();
                    try
                    {
                        if (!stocksWindow.IsActive)
                        {
                            Application.Current.Shutdown();
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    

                }
                else
                {
                    if(MessageBox.Show("Do You want to try Again?", "Invalid Password", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                            pwd_input.Clear();
                            pwd_input.Focus();
                    }
                    else
                    {
                        Application.Current.Shutdown();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
