using System;
using BreadLoaf;
namespace Bread.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void ReturnCount_GetsDayOfWeek_int()
    {
      Bread bread = new Bread(5, 10);
      Assert.AreEqual(5, bread.ReturnCount);
    }
  }
}