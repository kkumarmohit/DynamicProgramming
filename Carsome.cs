using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
  public class Carsome
  {
    public static void Main(String[] args)
    {
      Dictionary<int, int> map = new Dictionary<int, int>();
      double[] input = new double[] { 2, 9, 1, 5, 2, 3, 1, 2, 7, 4, 3, 8, 29, 2, 4, 6, 54, 32, 2, 100 };
      
      foreach (int i in input)
      {
        if (map.ContainsKey(i)) { map[i] += 1; }
        else { map[i] = 1; }
      }
      var max =  map.Values.Max();
      //If multiple elements has same frequency, the first one is given a higher priority.
      var maxKey =  map.FirstOrDefault(x => x.Value == max).Key;

      if(maxKey != 0)
      {
        var temp2 = input.Select((x) => x / maxKey);
        
      }
    }
  }
}
