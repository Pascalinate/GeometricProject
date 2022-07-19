// Function: to prompt user of radius, calculate surface area of the cube and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cube
{

    class SurfaceAreaOfCube:ICubeOperation
    {
        private double edge;
        public double Edge { get { return edge; } }

        public double Execute()
        {
            return 6 * Math.Pow(Edge, 2);
        }

        public double TakeDimensions()
        {
            TakeInput.InputEdge e = new TakeInput.InputEdge();
            e.GetEdge();
            edge = e.Edge;
            return edge;
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Surface area of the cube is {Execute()}\n\n");
        }
       
    }
}
