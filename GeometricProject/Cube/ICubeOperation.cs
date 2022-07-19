using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cube
{
    interface ICubeOperation
    {
        double TakeDimensions();

        double Execute();

        void DisplayResults();
    }
}
