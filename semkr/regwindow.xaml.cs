﻿using System;
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
    /// Логика взаимодействия для regwindow.xaml
    /// </summary>
    public partial class regwindow : Window
    {
        public regwindow()
        {
            InitializeComponent();
        }

        private void SignIn1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();

        }

       
    }
}
