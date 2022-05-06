namespace BreadLoaf
{
  public class Bread : FoodItem
  {
    public override int Count { get; set; }
    public Bread(int count) : base(count){}
  }
}