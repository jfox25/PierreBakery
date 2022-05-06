namespace PastryItem
{
  public class Pastry : FoodItem
  {
    public override int Count { get; set; }
    public override int Cost { get; set; }
    public override int DiscountRate { get; set; }
    public Pastry(int count, int cost, int discountRate) : base(count, cost, discountRate){}
 
  }
}