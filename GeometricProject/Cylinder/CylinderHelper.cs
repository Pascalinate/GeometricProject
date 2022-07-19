using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cylinder
{
    class CylinderHelper : IGeometricOperation
    {
        private int opId;
        public int OpId { get { return opId; } }


        public void Execute()
        {
            if (opId == 1)
            {
                SurfaceAreaOfCylinder op = new SurfaceAreaOfCylinder();
                op.TakeDimensions();
                op.Execute();
                op.DisplayResults();
                
            }
            if (opId == 2)
            {
                VolumeOfCylinder op = new VolumeOfCylinder();
                op.TakeDimensions();
                op.Execute();
                op.DisplayResults();
            }
        }

   
        public int ChooseOperationToBeDone()
        {
            while (true)
            {
                Console.Write(@"Cylinder...
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
