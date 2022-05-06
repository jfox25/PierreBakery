using System.Collections.Generic;
public abstract class FoodItem
{
   public abstract int Count { get; set; }  
   public abstract int Cost { get; set; }  
   public abstract int DiscountRate { get; set; }  
   public static int orderTotal = 0;

    public FoodItem(int count, int cost, int discountRate)
    {
        Count = count;
        Cost = cost;
        DiscountRate = discountRate;
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
          total += DiscountRate;
        }
      }
      return total;
   }
   public static int UpdateOrderTotal(int total)
   {
     orderTotal += total;
     return orderTotal;
   }
   
}