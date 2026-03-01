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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        LibraryContext db=new LibraryContext();
        Book Book=new Book();
        
        public Home()
        {
           
            InitializeComponent();
           boxcatg.ItemsSource=db.Books.Select(x => x.Category).ToList();
        }

    }
}
