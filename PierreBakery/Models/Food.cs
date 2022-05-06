public abstract class FoodItem
{
   public abstract int Cost { get; set; }  
   public abstract int Count { get; set; }  


    public FoodItem(int count)
    {
        Count = count;
    }
   public int ReturnCount()
   {
       return Count;
   }
}