using Book_exchange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Book_exchange.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public List<Account> accounts = new List<Account>();
        MainWindow MainW;
        public LoginWindow(List<Account> accounts, MainWindow mw)
        {
            InitializeComponent();
            this.accounts = accounts;
            MainW = mw;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Wrong username or password");
            }

            else 
            {
                this.Close();
            }
        }

        private bool check()
        {
            foreach (var account in accounts)
            {
                if (tbUsername.Text == account.Username && pbPass.Password == account.PasswordHash)
                {
                    MainW.user = account;
                    MainW.LoggedIn = true;
                    MainW.loginn.UserName.Text = account.Username;
                    return true;
                }
            }
            return false;
        }
    }
}
