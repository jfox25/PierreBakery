using System;
using PastryItem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PastryItem.Tests
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void ReturnCount_ReturnCountPastryItem_int()
    {
      Pastry pastry = new Pastry(5, 2, 1);
      Assert.AreEqual(5, pastry.ReturnCount());
    }
    [TestMethod]
    public void ReturnCost_ReturnCostPastryItem_int()
    {
      Pastry pastry = new Pastry(5, 2, 1);
      Assert.AreEqual(2, pastry.ReturnCost());
    }
    [TestMethod]
    public void CalculateCost_CalculateCostofPastryItems6_int()
    {
      Pastry pastry = new Pastry(6, 2, 1);
      Assert.AreEqual(10, pastry.CalculateCost());
    }
    [TestMethod]
    public void CalculateCost_CalculateCostofPastryItems10_int()
    {
      Pastry pastry = new Pastry(10, 2, 1);
      Assert.AreEqual(17, pastry.CalculateCost());
    }
  }
}