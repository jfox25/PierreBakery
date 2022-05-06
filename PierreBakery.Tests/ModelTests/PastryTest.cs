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
      Pastry pastry = new Pastry(5, 2);
      Assert.AreEqual(5, pastry.ReturnCount());
    }
    [TestMethod]
    public void ReturnCost_ReturnCostPastryItem_int()
    {
      Pastry pastry = new Pastry(5, 2);
      Assert.AreEqual(2, pastry.ReturnCost());
    }
  }
}