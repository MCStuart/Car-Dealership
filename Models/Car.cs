using System;

namespace Dealership {

  class Car
  {
    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    private string MakeModel;
    private int Price;
    private int Miles;

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
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
