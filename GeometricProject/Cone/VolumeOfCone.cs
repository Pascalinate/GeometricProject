// Function: to prompt user of radius, calculate volume of the cone and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cone
{

    class VolumeOfCone : IConeOperation
    {
        private double radius;
        public double Radius { get { return radius; } }
        private double height;
        public double Height { get { return height; } }

        public double Execute()
        {
            return Math.PI * Math.Pow(Radius, 2) * (Height/3);
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
            Console.WriteLine($"Perimeter of the cone is {Execute()}\n\n");
        }

    }
}
