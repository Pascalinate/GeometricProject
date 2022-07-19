using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProject.TakeInput
{
    internal class InputLength
    {
        private double length;
        public double Length { get { return length; } }
        public void GetLength()
        {
            Console.WriteLine("Enter the length: ");
            try
            {
                length = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"The length entered is not valid.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
