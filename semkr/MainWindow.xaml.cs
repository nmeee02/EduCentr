using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace semkr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            courses courses = new courses();
            courses.Show();
            this.Close();
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
            regwindow regwindow = new regwindow();
            regwindow.Show();
            this.Close();
            
        }

       
    }
}