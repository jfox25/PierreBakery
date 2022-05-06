using System;
namespace BreadLoaf
{
  public class Bread : FoodItem
  {
    public override int Count { get; set; }
    public override int Cost { get; set; }
    public override int Discount { get; set; }
    public Bread(int count, int cost, int discount) : base(count, cost, discount){}
  }
}