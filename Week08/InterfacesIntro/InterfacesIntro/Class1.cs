using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class C3PO : Robot
    {
        int inNumberOfMovies { get; set;}

        public C3PO(int inNumberOfMovies, double StrideLength, int NumLegs, string Name, int Height)
        {
            this.inNumberOfMovies = inNumberOfMovies;
            this.Height = Height;
            this.Name = Name;
            this.Numlegs = Numlegs;
            this.StrideLength = StrideLength;
        }
    }
}
