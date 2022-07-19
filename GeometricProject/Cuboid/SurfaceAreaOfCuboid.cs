// Function: to prompt user of radius, calculate surface area of the cuboid and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cuboid
{

    class SurfaceAreaOfCuboid : ICuboidOperation
    {
        private double width;
        public double Width { get { return width; } }
        private double height;
        public double Height { get { return height; } }
        private double length;
        public double Length { get { return length; } }

        public double Execute()
        {
            return (2 * Length *  Width) + (2 * Length * Height) + (2 * Height * Width);
        }

        public void TakeDimensions()
        {
            TakeInput.InputWidth w = new TakeInput.InputWidth();
            w.GetWidth();
            width = w.Width;

            TakeInput.InputHeight h = new TakeInput.InputHeight();
            h.GetHeight();
            height = h.Height;

            TakeInput.InputLength l = new TakeInput.InputLength();
            l.GetLength();
            length = l.Length;
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Surface area of the cuboid is {Execute()}\n\n");
        }
       
    }
}
