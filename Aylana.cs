using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Aylana
    {
        public double Radius { get; set; }
        public Aylana(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
