using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
     class Star_Wars_Robot : Robot
    {
        int InNumberOfMovies { get; set; }

        public Star_Wars_Robot(int inNumberOfMovies, double strideLength, int numLegs)
        {
            this.InNumberOfMovies = inNumberOfMovies;
            this.StrideLength = strideLength;
            this.NumLegs = NumLegs;
        }
    }
}
