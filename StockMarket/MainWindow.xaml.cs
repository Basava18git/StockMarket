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
           // mainContent.Content = new Views.CashFlowUI();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            //StocksWindow stocksWindow = new StocksWindow();
            try
            {

                if(pwd_input.Text == "")
                {
                    if (MessageBox.Show("Do You want to enter Password again?", "Empty Password", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        pwd_input.Focus();
                    }
                    
                }
                else
                {
                    if (pwd_input.Text == "9945706254")
                    {
                        //MessageBox.Show("Login Successful");
                        //mainWindow.Hide();

                        //stocksWindow.ShowDialog();

                        //try
                        //{
                        //    if (!stocksWindow.IsActive)
                        //    {
                        //        Application.Current.Shutdown();
                        //    }

                        //}

                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}
                        
                        mainContent.Content = new Views.StocksPage();
                        mainWindow.Close();
                        
                        //this.Hide();
                       
                        

                    }
                    else
                    {
                        if (MessageBox.Show("Do You want to try Again?", "Invalid Password", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                        {
                            pwd_input.Clear();
                            pwd_input.Focus();
                        }
                    }
                }
               //

            }
             
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
