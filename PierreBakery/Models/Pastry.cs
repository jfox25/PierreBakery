namespace PastryItem
{
  public class Pastry : FoodItem
  {
    public override int Count { get; set; }
    public override int Cost { get; set; }
    public Pastry(int count, int cost) : base(count, cost){}
     public override int CalculateCost()
    {
      return Cost;
    }
  }
  
}