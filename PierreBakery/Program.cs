using System;
using BreadLoaf;
using PastryItem;

public class Program
{
  static void Main()
  {
    if(FoodItem.orderTotal == 0)
    {
      WelcomeMessage();
    }
    Console.WriteLine("How many loaves of bread would you like to buy?");
    int breadCount = int.Parse(Console.ReadLine());
    Bread bread = new Bread(breadCount, 5, 0);
    Console.WriteLine("How many pastries would you like to buy?");
    int pastryCount = int.Parse(Console.ReadLine());
    Pastry pastry = new Pastry(pastryCount, 2, 1);
    Console.ForegroundColor = ConsoleColor.Green;
    int total = FoodItem.UpdateOrderTotal(bread.CalculateCost() + pastry.CalculateCost());
    Console.WriteLine("Your total is: $" + total);
    Console.ForegroundColor = ConsoleColor.White;
    Continue();
  }
  public static void Continue()
  {
    Console.WriteLine("Want to add more items? \n(1) Yes \n(2) Exit");
    int response = int.Parse(Console.ReadLine());
    if(response == 1)
    {
      Main();
    }else if(response != 1 && response != 2)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Invalid Input");
      Console.ForegroundColor = ConsoleColor.White;
      Continue();
    }
  }
  public static void WelcomeMessage()
  {
    Console.ForegroundColor = ConsoleColor.Blue; 
    Console.WriteLine("Welcome to Pierre's Bakery");
    Console.ForegroundColor = ConsoleColor.White; 
    Console.WriteLine("Today we are serving Bread and Pastries");
    Console.WriteLine("Bread is $5 per loaf, but if you buy 2, the third is free");
    Console.WriteLine("A pastry is $2, but if you buy 2, the third is half off");
  }
}