using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    class Robot : IWalker
    {
        public double Maxspeed { get; set; }
     

        public int Numlegs { get; set; }
      

        public double StrideLength { get; set; }
       
        public string Name { get; set;}

        public int Height { get; set; }

        public void walk()
        {
            MessageBox.Show("Beep Boop " + Numlegs + "LMAO XD legs");
        }
    }
    
    
}


