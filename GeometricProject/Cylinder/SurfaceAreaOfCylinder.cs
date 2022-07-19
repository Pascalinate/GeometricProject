// Function: to prompt user of radius, calculate surface area of the cylinder and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cylinder
{

    class SurfaceAreaOfCylinder : ICylinderOperation
    {
        private double radius;
        public double Radius { get { return radius; } }
        private double height;
        public double Height { get { return height; } }

        public double Execute()
        {
            return (2 * Math.PI * Radius * Height) + (2 * Math.PI * Math.Pow(Radius, 2));
        }

        public void TakeDimensions()
        {
            TakeInput.InputRadius r = new TakeInput.InputRadius();
            r.GetRadius();
            radius = r.Radius;

            TakeInput.InputHeight h = new TakeInput.InputHeight();
            h.GetHeight();
            height = h.Height;
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Surface area of the cylinder is {Execute()}\n\n");
        }
       
    }
}
