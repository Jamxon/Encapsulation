using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Car
    {
        private int speed;

        public void Accelerate(int amount)
        {
            if (amount <= 200)
                this.speed = amount;
        }

        public void Brake(int amount)
        {
            if (amount >= 0)
                this.speed = amount;
        }

        public int GetSpeed()
        {
            return this.speed; 
        }
    }
}
