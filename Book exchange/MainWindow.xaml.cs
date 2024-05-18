using Book_exchange.Pages;
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

namespace Book_exchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool LoggedIn = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BrowsePage();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();
        }

        private void btnMyLists_Click(object sender, RoutedEventArgs e)
        {
            if (!LoggedIn)
            {
                Main.Content = new NotLoggedInListsPage();
            }
            else
            {
                Main.Content = new ListsPage();
            }
            
        }
    }
}
