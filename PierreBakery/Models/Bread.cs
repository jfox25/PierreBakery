using System;
namespace BreadLoaf
{
  public class Bread : FoodItem
  {
    public override int Count { get; set; }
    public override int Cost { get; set; }
    public Bread(int count, int cost) : base(count, cost){}

    public override int CalculateCost()
    {
      int total= 0;
      for (int i = 1; i < Count + 1; i++)
      {
        Console.WriteLine(i);
        if(i%3 != 0)
        {
          total += Cost;
        }
      }
      return total;
    }
  }
}