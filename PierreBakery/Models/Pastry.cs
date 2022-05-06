namespace PastryItem
{
  public class Pastry : FoodItem
  {
    public override int Count { get; set; }
    public override int Cost { get; set; }
    public override int Discount { get; set; }
    public Pastry(int count, int cost, int discount) : base(count, cost, discount){}
 
  }
}