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
    /// Interaction logic for EmergencyEnding.xaml
    /// </summary>
    public partial class EmergencyEnding : Window
    {
        public EmergencyEnding()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Hide();
            window.Show();
        }
    }
}
