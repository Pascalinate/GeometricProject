// Function: to prompt user of radius, calculate volume of the cube and display the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.Cube
{

    class VolumeOfCube : ICubeOperation
    {
        private double edge;
        public double Edge { get { return edge; } }

        public double Execute()
        {
            return Math.Pow(Edge, 3);
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
            Console.WriteLine($"Volume of the cube is {Execute()}\n\n");
        }

    }
}
