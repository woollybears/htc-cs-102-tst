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
    /// Interaction logic for SchoolLife.xaml
    /// </summary>
    public partial class SchoolLife : Window
    {
        public SchoolLife()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int genRand = r.Next(1, 3);
            if (genRand == 1)
            {
                MessageBox.Show("Your in!");
            }
            if (genRand == 2)
            {
                MessageBox.Show("Sorry, you aren't their type.");
            }
            string Place = Convert.ToString(genRand);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Friendships window = new Friendships();
            window.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Grad window = new WpfApplication1.Grad();
            this.Hide();
            window.Show();
        }
    }
}
