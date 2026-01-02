using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Uchburchak
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Uchburchak(double b, double height)
        {
            Base = b;
            Height = height;
        }
        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
