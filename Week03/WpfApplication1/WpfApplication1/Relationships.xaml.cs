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
    /// Interaction logic for Relationships.xaml
    /// </summary>
    public partial class Relationships : Window
    {
        public Relationships()
        {
            InitializeComponent();
        }
        int RelationStat = 50;
        private void TaketoTheater(object sender, RoutedEventArgs e)
        {
            RelationStat = 60;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(RelationStat));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RelationStat = 55;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RelationStat = 30;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            RelationStat = 20;
        }
    }
}
