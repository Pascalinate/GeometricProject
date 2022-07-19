using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.TakeInput
{
 
    class InputWidth
    {   
        private double width;
        public double Width { get { return width; } }
        public void GetWidth()
        {
             Console.WriteLine("Enter the width: ");
                try
                {
                    width = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The width entered is not valid.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Unexpected error: {e.Message}");
                }
        }
       
    }
}
