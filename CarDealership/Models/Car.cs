using System;
using System.Collections.Generic;

namespace CarDealership {

  public class Car
  {

    private string MakeModel;
    private int Price;
    private int Miles;

    static List<Car> myCarList = new List<Car>();

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      myCarList.Add(this);
    }

    public static List<Car> GetList()
    {
      return myCarList;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }
    
    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public bool WorthMiles(int maxMileage)
    {
      return (Miles < maxMileage);
    }

    public string CarMessage()
    {
      return "Are you interested in the ";
    }

  }

}
