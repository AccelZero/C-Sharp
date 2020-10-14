using System;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stoneHouse = new StoneHouse();
            var woodenHouse = new WoodenHouse();

            Console.WriteLine(stoneHouse);
            stoneHouse.building();
            Console.WriteLine("=====================================================================");
            Console.WriteLine(woodenHouse);
            woodenHouse.building();
            Console.ReadLine();
        }
    }
}