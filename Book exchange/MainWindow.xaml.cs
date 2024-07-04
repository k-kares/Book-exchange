using Book_exchange.Model;
using Book_exchange.Pages;
using Book_exchange.Windows;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Account> accounts = new List<Account>();
        public Account user { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            FillData();
            
        }

        private void FillData()
        {
            string connectionString = "Data Source=DESKTOP-16H5M17;Initial Catalog=oicardatabase;Integrated Security=True;Connect Timeout=30;Encrypt=false;";

            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement =
                    "SELECT * FROM Account";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable customerTable = new DataTable("Account");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(customerTable);
                    _con.Close();

                    FillListOfAccounts(customerTable);

                    string Product_Category = String.Empty;
                }
            }
        }

        private void FillListOfAccounts(DataTable customerTable)
        {
            
            {

                var convertedList = (from rw in customerTable.AsEnumerable()
                                     select new Account()
                                     {
                                         IDAccount = Convert.ToInt32(rw["IDAccount"]),
                                         Username = Convert.ToString(rw["Username"]),
                                         PasswordHash = Convert.ToString(rw["PasswordHash"]),
                                     }).ToList();

                accounts = convertedList;
            }
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

        private void UserLogin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window w1 = new LoginWindow(accounts, this);
            w1.Show();
        }
    }
}
