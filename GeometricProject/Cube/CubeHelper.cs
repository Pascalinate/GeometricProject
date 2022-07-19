using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cube
{
    class CubeHelper : IGeometricOperation
    {
        private int opId;
        public int OpId { get { return opId; } }


        public void Execute()
        {
            if (opId == 1)
            {
                SurfaceAreaOfCube op = new SurfaceAreaOfCube();
                op.TakeDimensions();
                op.Execute();
                op.DisplayResults();
                
            }
            if (opId == 2)
            {
                VolumeOfCube op = new VolumeOfCube();
                op.TakeDimensions();
                op.Execute();
                op.DisplayResults();
            }
        }

   
        public int ChooseOperationToBeDone()
        {
            while (true)
            {
                Console.Write(@"Cube...
1. Surface area
2. Volume
Press any other to go back.
");
                opId = !int.TryParse(Console.ReadLine(), out opId) ? 0 : opId;
                return opId;
            }
        }
    }
}
