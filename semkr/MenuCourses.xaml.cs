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
    /// Логика взаимодействия для MenuCourses.xaml
    /// </summary>
    public partial class MenuCourses : Window
    {
        public MenuCourses()
        {
            InitializeComponent();
        }

        private void MyCousers1(object sender, RoutedEventArgs e)
        {
            MyCourses mycourses = new MyCourses();
            mycourses.Show();
            this.Close();
        }

        private void BackToCourses(object sender, RoutedEventArgs e)
        {
            courses courses = new courses();
            courses.Show();
            this.Close();
        }

        
    }
}
