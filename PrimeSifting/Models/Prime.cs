using System.Collections.Generic;
using System;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public static List<int> GenerateNumList(int num)
    {
      List<int> numberList = new List<int> {};
      int counter = 2;
      for (int i = 0; i < (num - 1); i++) 
      {
        numberList.Add(counter); 
        counter++;
      }
       return numberList;
    }

    public static bool FindPrime(List<int> numberList)
    {
      int prime = 2;
      if (numberList.Contains(prime))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static List<int> MultiplesOfPrime(List<int> numberList)
    {
      int prime = 2;
      return new List<int> {3, 5};
    }
  }
}