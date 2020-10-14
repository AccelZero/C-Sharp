using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class StoneHouse : House
    {
        protected override void Buyland()
        {
            Console.WriteLine("Закупается земля под размеры каменного дома.");
        }
        protected override void Projecting()
        {
            Console.WriteLine("Проектируется каменный дом.");
        }
        protected override void BuyMaterial()
        {
            Console.WriteLine("Закупается камень.");
        }
        protected override void BuildingHouse()
        {
            Console.WriteLine("Строится каменный дом.");
        }
        public override string ToString()
        {
            return "Каменный дом";
        }
    }
}