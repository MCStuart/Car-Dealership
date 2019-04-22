using System;

namespace Dealership {

  class Car
  {
    public string MakeModel;
    public int Price;
    public int Miles;
    public string CarComment;

    public Car(string makeModel, int price, int miles, string carComment)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      CarComment = carComment;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price < maxPrice && Miles < maxMiles);
    }
  }

}
