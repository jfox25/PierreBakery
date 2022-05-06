public abstract class FoodItem
{
   public abstract int Count { get; set; }  
   public abstract int Cost { get; set; }  
   public abstract int Discount { get; set; }  

    public FoodItem(int count, int cost, int discount)
    {
        Count = count;
        Cost = cost;
        Discount = discount;
    }
   public int ReturnCount()
   {
       return Count;
   }
   public int ReturnCost()
   {
       return Cost;
   }
   public int CalculateCost()
   {
      int total= 0;
      for (int i = 1; i <= Count; i++)
      {
        if(i%3 != 0)
        {
          total += Cost;
        }else{
          total += Discount;
        }
      }
      return total;
   }
   
}