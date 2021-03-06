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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorld
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

        int ClickCount = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestText.Text = "Clicked: " + ++ClickCount;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Are you sure you want to quit?", "Alert", MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
