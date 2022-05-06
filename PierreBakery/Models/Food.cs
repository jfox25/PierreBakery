public abstract class FoodItem
{
   public abstract int Count { get; set; }  
   public abstract int Cost { get; set; }  

    public FoodItem(int count, int cost)
    {
        Count = count;
        Cost = cost;
    }
   public int ReturnCount()
   {
       return Count;
   }
   public int ReturnCost()
   {
       return Cost;
   }
   public abstract int CalculateCost();
   
}