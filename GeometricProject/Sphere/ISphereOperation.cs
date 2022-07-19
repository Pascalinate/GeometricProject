using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Sphere
{
    interface ISphereOperation
    {
        double TakeDimensions();

        double Execute();

        void DisplayResults();
    }
}
