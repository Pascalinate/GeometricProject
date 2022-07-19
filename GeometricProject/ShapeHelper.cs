// Function: to choose shapes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometricProject
{
    enum Shape
    {
        Circle, Cube, Cuboid, Cylinder, Cone
    }
    class ShapeHelper
    {
        public static IGeometricOperation ShapeChoice(int shapeId)
        {
            if (shapeId == 1)
            {
                return new Sphere.SphereHelper();
            }
            if (shapeId == 2)
            {
                return new Cube.CubeHelper();
            }
            if (shapeId == 3)
            {
                return new Cuboid.CuboidHelper();
            }
            if (shapeId == 4)
            {
                return new Cylinder.CylinderHelper();
            }
            if (shapeId == 5)
            {
                return new Cone.ConeHelper();
            }
            else
            {
                return null;
            }
        }

        public static int ChooseShape()
        {
            int shapeId = 0;

            Console.WriteLine(@"****************** WELCOME ******************
Choose a geometric shape: 
    1. Sphere
    2. Cube
    3. Cuboid
    4. Cylinder
    5. Cone
Press -1 to exit.
");

            shapeId = !int.TryParse(Console.ReadLine(), out shapeId) ? 0 : shapeId; 
            return shapeId;

        }
    }
}
