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
      List<int> newList = new List<int> { }; // generate list from 2 to n
      //CollectionAssert.AreEqual(newList, result);
      Assert.AreEqual(typeof(List<int>), newList.GetType());
    }

    [TestMethod]
    public void GenerateNumList_PopulateListOfNumbers_NumberList()
    {
      // Arrange
      int num = 10;
       Prime newItem = new Prime();
       List<int> newList = new List<int> { };
       List<int> expected = new List<int> {2, 3, 4, 5, 6, 7, 8, 9, 10};
       List<int> actual;
       actual = Prime.GenerateNumList(num);
      //  GenerateNumList(num);
       //Console.WriteLine(newList + );

      // Act


       // Assert
       CollectionAssert.AreEqual(expected, actual);
    // newList = {2, 3, 4, 5, 6, 7, 8, 9, 10}
    }
  }
}