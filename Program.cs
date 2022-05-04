namespace DPFib;

public class Program
{
  public static void Main(string[] args)
  {
    long[] memo = new long[200];
    Console.WriteLine(RecurFib(6, memo));
    Console.WriteLine(RecurFib(7, memo));
    Console.WriteLine(RecurFib(8, memo));
    Console.WriteLine(RecurFib(50, memo));
  }

  //To speed up the process and store already calculated values we need memoization and store these values in a fast access datastructure.
  public static long RecurFib(int n, long[] memo)
  {
    
    if (memo[n] != 0)
      return memo[n];
    if (n <= 2)
      return 1;
    memo[n] = RecurFib(n - 1, memo) + RecurFib(n - 2, memo);
    return memo[n]; // Time complexity is 2 raise to power n and space is O (n), We need to store already calculated values with DP.
  }
}
