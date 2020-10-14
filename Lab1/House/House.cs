using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class House
    {
        public void building()
        {
            Buyland();
            Projecting();
            BuyMaterial();
            BuildingHouse();
        }
        protected abstract void Buyland();
        protected abstract void Projecting();
        protected abstract void BuyMaterial();
        protected abstract void BuildingHouse();
    }
}
