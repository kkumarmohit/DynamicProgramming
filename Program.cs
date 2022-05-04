namespace DPFib;

public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine(RecurFib(5));
    Console.WriteLine(RecurFib(2));
    Console.WriteLine(RecurFib(3));
    Console.WriteLine(RecurFib(50));
  }

  public static int RecurFib(int n)
  {
    if (n <= 2)
      return 1;
    return RecurFib(n - 1) + RecurFib(n -2); // Time complexity is 2 raise to power n and space is O (n), We need to store already calculated values with DP.
  }
}
