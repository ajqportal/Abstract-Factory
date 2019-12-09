using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.AbstractFactory.Factory.AbstractProducts;
using Design.Pattern.AbstractFactory.Factory.Interfaces;

namespace Design.Pattern.AbstractFactory.Factory.Factories
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            throw new NotImplementedException();
        }

        public Sofa CreateSofa()
        {
            throw new NotImplementedException();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            throw new NotImplementedException();
        }
    }
}
