using System;
using Design.Pattern.AbstractFactory.Factory.Clients;
using Design.Pattern.AbstractFactory.Factory.Furnitures.Chairs;
using Design.Pattern.AbstractFactory.Factory.Furnitures.CoffeeTable;
using Design.Pattern.AbstractFactory.Factory.Furnitures.Sofa;

namespace Design.Pattern.AbstractFactory.Factory
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var modernFurniturePurchase =
                new FurnitureClient(new ModernChair(), new VictorianSofa(), new ModernCoffeeTable());
            Console.WriteLine(modernFurniturePurchase.ChooseYourFurniture());
            Console.ReadLine();
        }
    }
}
