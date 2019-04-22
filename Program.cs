using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Wow! Great choice!");
      Car ford = new Car("2011 Ford F450", 55995, 14241, "You know work trucks!");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "What a nice car.");
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "You have good taste.");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("Enter maximum miles: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if (CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("We're sorry. We do not have any cars that meet your requirements.");
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.CarComment);
      }
    }
  }

}
