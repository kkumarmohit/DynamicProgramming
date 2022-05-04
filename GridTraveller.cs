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
      Console.WriteLine(gridTraveller(1, 1));
      Console.WriteLine(gridTraveller(2, 3));
      Console.WriteLine(gridTraveller(3, 2));
      Console.WriteLine(gridTraveller(18, 18));
    }

    public static int gridTraveller(int m, int n)
    {
      if (m == 1 && n == 1) return 1;
      if(m == 0 || n == 0) return 0;
      return gridTraveller(m-1, n) + gridTraveller(m, n-1);
    }
  }
}
