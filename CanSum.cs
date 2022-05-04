using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
  //For a target sum 'm' and and an integer array of length of 'n'. Find if any combination of array elements can get a target sum.
  public class CanSum
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(canSum(7,new int[] { 2, 3 }));
      Console.WriteLine(canSum(7, new int[] { 5, 3, 4, 7 }));
      Console.WriteLine(canSum(8, new int[] { 2, 3, 5 }));
      Console.WriteLine(canSum(300, new int[] { 7, 14 }));
    }

    public static Boolean canSum(int targetSum, int[] numbers)
    {
      if (targetSum == 0) return true;
      if (targetSum < 0) return false;

      foreach(int number in numbers)
      {
        int remainder = targetSum - number;
        if((canSum(remainder, numbers)) == true) return true; //brute force recursion gives time complexity of 2^(n+m) [m will be height of tree with
                                                              //each node will have at max m children] and space complexity of O(m).
      }
      return false;
    }
  }
}
