using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    class Person
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Traits { get; set; }


        public Person(string Name, string Location, string Traits)
        {
            this.Name = Name;
            this.Location = Location;
            this.Traits = Traits;
        }

        public void Show()
        {
            MessageBox.Show("The name of this person is " + Name + ". The location of " + Name + " is " + Location + ". This person's main trait is " + Traits + ". By exiting this window, you agree to all of the information shown as it will affect your story. If you do not agree, restart the game.");
        }
    }

    

}
