using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cuboid
{
    interface ICuboidOperation
    {
        void TakeDimensions();

        double Execute();

        void DisplayResults();
    }
}
