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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for _14yo.xaml
    /// </summary>
    public partial class _14yo : Window
    {
        public _14yo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _20yoREWARD window = new _20yoREWARD();
            window.Show();
         
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _20yo window1 = new _20yo();
            window1.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Relationships window1 = new Relationships();
            window1.Show();
        }
    }
}