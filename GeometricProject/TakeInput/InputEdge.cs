using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.TakeInput
{
    class InputEdge
    {
        private double edge;
        public double Edge { get { return edge; } }
        public void GetEdge()
        {
            Console.WriteLine("Enter the edge: ");
            try
            {
                edge = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The edge entered is not valid.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
