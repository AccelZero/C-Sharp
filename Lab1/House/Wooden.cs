using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class WoodenHouse : House
    {
        protected override void Buyland()
        {
            Console.WriteLine("Закупается земля под размеры деревянного дома.");
        }
        protected override void Projecting()
        {
            Console.WriteLine("Проектируется деревянный дом.");
        }
        protected override void BuyMaterial()
        {
            Console.WriteLine("Закупается древесина.");
        }
        protected override void BuildingHouse()
        {
            Console.WriteLine("Строится деревянный дом.");
        }
        public override string ToString()
        {
            return "Деревянный дом";
        }
    }
}