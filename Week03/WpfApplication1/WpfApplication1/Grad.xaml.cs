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
    /// Interaction logic for Grad.xaml
    /// </summary>
    public partial class Grad : Window
    {
        public Grad()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to Woolly Collision and Restortation Facility! Here we repair and restore vehicles. The Salary is a hefty $60,000, enjoy the job!");
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to McDonalds. After 4 years of college you decide to go with us? The Salary is only $10,000. Enjoy.");
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to Bearz Clinic! Here, you will be Nurse. The Salary is a nice $40,000 to start.");
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to being Unemployed! Maybe you aren't ready for a job. The Salary is $0.");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmergencyEnding window = new EmergencyEnding();
            this.Hide();
            window.Show();
        }
    }
}
