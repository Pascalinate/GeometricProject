using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cone
{
    interface IConeOperation
    {
        void TakeDimensions();

        double Execute();

        void DisplayResults();
    }
}
