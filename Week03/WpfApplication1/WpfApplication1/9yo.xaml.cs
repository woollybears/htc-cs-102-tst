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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for _9yo.xaml
    /// </summary>
    public partial class _9yo : Window
    {
        public _9yo()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Death Die = new Death();
            Die.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _14yo window = new _14yo();
            window.Show();
        }
    }
}
