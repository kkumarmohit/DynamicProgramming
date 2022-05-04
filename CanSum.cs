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
      //TODO: Reset the memo object before every calculation
      Dictionary<int,bool> memo = new Dictionary<int, bool>();
      //Console.WriteLine(canSum(7,new int[] { 2, 3 }, memo));
      //Console.WriteLine(canSum(7, new int[] { 5, 3, 4, 7 }, memo));
      //Console.WriteLine(canSum(8, new int[] { 2, 3, 5 }, memo));
      Console.WriteLine(canSum(300, new int[] { 7, 14 }, memo));
    }

    public static bool canSum(int targetSum, int[] numbers, Dictionary<int, bool> memo)
    {

      if (memo.ContainsKey(targetSum)) return memo[targetSum];
      if (targetSum == 0) return true;
      if (targetSum < 0) return false;
      

      foreach (int number in numbers)
      {
        int remainder = targetSum - number;
        if((canSum(remainder, numbers, memo)) == true)    //With memoization Time complexity O(n+m) and space complexity O(m)
        {
          memo[targetSum] = true;
          return true;
        } 
      }
      memo[targetSum] = false;
      return false;
    }
  }
}
