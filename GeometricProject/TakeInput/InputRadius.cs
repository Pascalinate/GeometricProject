using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.TakeInput
{
    class InputRadius
    {
        private double radius;
        public double Radius { get { return radius; } }
        public void GetRadius()
        {
            Console.WriteLine("Enter the radius: ");
            try
            {
                radius = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The radius entered is not valid.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
