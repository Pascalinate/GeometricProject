using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject
{
    class Program
    {
        

        static void Main(string[] args)
        {

            GeometricCalculation();
        }

        public static void GeometricCalculation()
        {            
            while (true)
            {
                int shapeId = ShapeHelper.ChooseShape(); // message to choose shape
                IGeometricOperation op = ShapeHelper.ShapeChoice(shapeId); // actual shape chosen
                if (op == null) break;
                op.ChooseOperationToBeDone(); // on the shape
                op.Execute();
            }
        }
    }
}
