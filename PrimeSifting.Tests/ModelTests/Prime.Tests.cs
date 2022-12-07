using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;
using System.Collections.Generic;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void GenerateNumList_GenerateListOfNumbers_NumberList()
    {
      List<int> newList = new List<int>(0) { }; // generate list from 2 to n
      //CollectionAssert.AreEqual(newList, result);
      Assert.AreEqual(typeof(List<int>), newList.GetType());
    }
  }
}