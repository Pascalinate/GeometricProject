using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.TakeInput
{
    internal class InputHeight
    {
        private double height;
        public double Height { get { return height; } }
        public void GetHeight()
        {
            Console.WriteLine("Enter the height: ");
            try
            {
                height = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The height entered is not valid.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
