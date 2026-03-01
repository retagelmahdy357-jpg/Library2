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
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        LibraryContext db=new LibraryContext(); 
        public Signup()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (boxsinpassword.Text != boxsinconpassword.Text)
            {
                MessageBox.Show("Does not match");
                return;
            }
             
            User user = new User();
            user.FullName = boxsinname.Text;
            user.Email = boxsinemail.Text;
            user.Password = boxsinpassword.Text;
            user.Role = boxsinrole.Text;
            if (radio1.IsChecked.Value)
            {
                user.Role = "Librarian";
            }
            else
            {
                user.Role = "Member";
            }
            db.Users.Add(user);
            db.SaveChanges();
            NavigationService.Navigate(new Login());


        }
    }
}
