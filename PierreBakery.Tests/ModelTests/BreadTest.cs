using System;
using BreadLoaf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BreadLoaf.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void ReturnCount_GetsDayOfWeek_int()
    {
      Bread bread = new Bread(5);
      Assert.AreEqual(5, bread.ReturnCount());
    }
  }
}