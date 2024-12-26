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
using System.Windows.Shapes;

namespace semkr
{
    /// <summary>
    /// Логика взаимодействия для courses.xaml
    /// </summary>
    public partial class courses : Window
    {
        public courses()
        {
            InitializeComponent();
        }

        private void MyCourses(object sender, RoutedEventArgs e)
        {
            MenuCourses menuCourses = new MenuCourses();
            menuCourses.Show();
            this.Close();
        }

        private void MyEntries(object sender, RoutedEventArgs e)
        {
            MyCourses myCourses = new MyCourses();
            myCourses.Show();
            this.Close();
        }

        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
