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
    /// Interaction logic for Friendships.xaml
    /// </summary>
    public partial class Friendships : Window
    {
        public Friendships()
        {
            InitializeComponent();
            
        }
        int Friendship = 50;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Friendship = 10;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Friendship = 55;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Friendship = 45;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(Friendship));
        }
    }
}
