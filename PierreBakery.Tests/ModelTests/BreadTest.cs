using System;
using BreadLoaf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BreadLoaf.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void ReturnCount_ReturnCountofBread_int()
    {
      Bread bread = new Bread(5, 3, 0);
      Assert.AreEqual(5, bread.ReturnCount());
    }
    [TestMethod]
    public void ReturnCost_ReturnCostofBread_int()
    {
      Bread bread = new Bread(5, 3, 0);
      Assert.AreEqual(3, bread.ReturnCost());
    }
    [TestMethod]
    public void CalculateCost_ReturnCostofBreads_int()
    {
      Bread bread = new Bread(6, 5, 0);
      Assert.AreEqual(20, bread.CalculateCost());
    }
  }
}