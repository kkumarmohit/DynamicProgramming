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
    return RecurFib(n - 1) + RecurFib(n -2);
  }
}
