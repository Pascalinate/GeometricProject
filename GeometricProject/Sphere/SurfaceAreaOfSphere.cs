// Function: to prompt user of radius, calculate surface area of the sphere and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Sphere
{

    class SurfaceAreaOfSphere:ISphereOperation
    {
        private double radius;
        public double Radius { get { return radius; } }

        public double Execute()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double TakeDimensions()
        {
            TakeInput.InputRadius r = new TakeInput.InputRadius();
            r.GetRadius();
            radius = r.Radius;

            return radius;
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Surface area of the sphere is {Execute()}\n\n");
        }
       
    }
}
