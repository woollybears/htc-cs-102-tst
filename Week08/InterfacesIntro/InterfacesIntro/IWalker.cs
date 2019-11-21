using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    public interface IWalker
    {
        double Maxspeed { get; set; }
        int Numlegs { get; set; }
        double StrideLength { get; set; }

        void walk();
    }

}
