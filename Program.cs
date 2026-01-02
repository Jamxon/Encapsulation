using System;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Accelerate(200);
            Console.WriteLine(car.GetSpeed());

            car.Brake(50);
            Console.WriteLine(car.GetSpeed());

            UserAccount user = new UserAccount("jamkhan");

            user.SetPassword("12345678");

            Console.WriteLine(user.Login("12345678"));
            Console.WriteLine(user.Login("wrongpass"));
        }
    }
}
