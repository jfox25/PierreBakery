using System;
using BreadLoaf;
using PastryItem;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery");
    Console.WriteLine("Today we are serving Bread and Pastries");
    Console.WriteLine("Bread is $5 per loaf, but if you buy 2, the third is free");
    Console.WriteLine("A pastry is $2, but if you buy 2, the third is half off");
    Console.WriteLine("How many loaves of bread would you like to buy?");
    int breadCount = int.Parse(Console.ReadLine());
    Bread bread = new Bread(breadCount, 5, 0);
    Console.WriteLine("How many pastries would you like to buy?");
    int pastryCount = int.Parse(Console.ReadLine());
    Pastry pastry = new Pastry(pastryCount, 2, 1);
    Console.WriteLine("Your total is: " + (bread.CalculateCost() + pastry.CalculateCost()));
  }
}