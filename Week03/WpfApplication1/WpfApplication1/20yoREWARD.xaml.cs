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
    /// Interaction logic for _20yoREWARD.xaml
    /// </summary>
    public partial class _20yoREWARD : Window
    {
        public _20yoREWARD()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int genRand = r.Next(1, 3);
            if (genRand == 1)
                {
                MessageBox.Show("Accepted!");
                }
            if (genRand == 2)
            {
                MessageBox.Show("Denied.");
            }
        }
    }
}
