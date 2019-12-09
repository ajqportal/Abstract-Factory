using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.AbstractFactory.Factory.AbstractProducts;
using Design.Pattern.AbstractFactory.Factory.Furnitures.Chairs;
using Design.Pattern.AbstractFactory.Factory.Furnitures.CoffeeTable;
using Design.Pattern.AbstractFactory.Factory.Furnitures.Sofa;
using Design.Pattern.AbstractFactory.Factory.Interfaces;

namespace Design.Pattern.AbstractFactory.Factory.Factories
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ModernChair();
        }

        public Sofa CreateSofa()
        {
            return new ModernSofa();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }
}
