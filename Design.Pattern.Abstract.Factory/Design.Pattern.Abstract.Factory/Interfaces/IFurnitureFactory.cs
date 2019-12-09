using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.AbstractFactory.Factory.AbstractProducts;

namespace Design.Pattern.AbstractFactory.Factory.Interfaces
{
    public interface IFurnitureFactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        CoffeeTable CreateCoffeeTable();
    }
}
