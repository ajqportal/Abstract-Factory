using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.AbstractFactory.Factory.AbstractProducts;

namespace Design.Pattern.AbstractFactory.Factory.Clients
{
    public class FurnitureClient
    {
        private readonly Chair _chair;
        private readonly Sofa _sofa;
        private readonly CoffeeTable _coffeeTable;

        public FurnitureClient(Chair chair, Sofa sofa, CoffeeTable coffeeTable)
        {
            _chair = chair;
            _sofa = sofa;
            _coffeeTable = coffeeTable;
        }

        public string ChooseYourFurniture()
        {
            return $"Today I will purchase a {_chair.GetType().Name}, {_sofa.GetType().Name}, and {_coffeeTable.GetType().Name}.";
        }
    }
}
