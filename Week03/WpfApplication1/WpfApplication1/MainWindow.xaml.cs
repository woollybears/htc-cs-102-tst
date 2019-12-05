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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window2 ree = new Window2();
            ree.Show();
            this.Hide();

            Person submittedPerson = new Person(Name.Text, Location.Text, Traits.Text);

            submittedPerson.Name = Name.Text;
            submittedPerson.Location = Location.Text;
            submittedPerson.Traits = Traits.Text;
            submittedPerson.Show();
        }
    }
}
