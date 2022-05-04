using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//To find no. of ways to travel a rectangle/square grid of size (m,n) with either going down or right. Starting position is top left corner and final position is bottom right corener
namespace DynamicProgramming
{
  public class GridTraveller
  {
    public static void Main(string[] args)
    {
      Dictionary<string, long> memo = new Dictionary<string, long>();
      Console.WriteLine(gridTraveller(1, 1, memo));
      Console.WriteLine(gridTraveller(2, 3, memo));
      Console.WriteLine(gridTraveller(3, 2, memo));
      Console.WriteLine(gridTraveller(18, 18, memo));
    }

    public static long gridTraveller(int m, int n, Dictionary<string, long> memo)
    {
      string key = (m.ToString() + ',' + n.ToString());
      if (memo.ContainsKey(key)) return memo[key];
      if (m == 1 && n == 1) return 1;
      if(m == 0 || n == 0) return 0;
      memo[key] = gridTraveller(m-1, n, memo) + gridTraveller(m, n-1, memo); // Using a dictionary to memoiaze - new time compplexity is O(n+m) and space O(n+m)
      return memo[key];
    }
  }
}
