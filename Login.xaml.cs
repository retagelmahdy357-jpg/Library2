using Library2.Models;
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

namespace Library2
{
   
    public partial class Login : Page
    {
        LibraryContext db=new LibraryContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            User user = db.Users.FirstOrDefault(x => x.Email == boxsinemail.Text && x.Password == boxsinpassword.Text);
            if (user != null)
            {
                NavigationService.Navigate(new Home());
            }
            else
            {
                MessageBox.Show("dose not exsit");
            }
            
        }
    }
}
