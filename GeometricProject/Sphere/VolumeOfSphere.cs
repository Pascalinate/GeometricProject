// Function: to prompt user of radius, calculate volume of the sphere and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Sphere
{

    class VolumeOfSphere : ISphereOperation
    {
        private double radius;
        public double Radius { get { return radius; } }

        public double Execute()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
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
            Console.WriteLine($"Volume of the sphere is {Execute()}\n\n");
        }

    }
}
