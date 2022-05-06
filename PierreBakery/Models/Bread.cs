namespace BreadLoaf
{
  public class Bread : FoodItem
  {
    public override int Count { get; set; }
    public override int Cost { get; set; }
    public override int DiscountRate { get; set; }
    public Bread(int count, int cost, int discountRate) : base(count, cost, discountRate){}
  }
}