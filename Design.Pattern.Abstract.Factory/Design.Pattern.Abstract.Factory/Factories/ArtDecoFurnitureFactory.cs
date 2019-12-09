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
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ArtDecoChair();
        }

        public Sofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }
}
