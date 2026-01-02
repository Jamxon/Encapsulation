using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Tortburchak : Shakl
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Tortburchak(double length, double width)
        {
            Length = length;
            Width = width;
        }


        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
