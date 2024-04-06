namespace Lab10;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Addition");
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter number m:");
        int m = int.Parse(Console.ReadLine()!);
        Console.WriteLine(CalculateSumOfNumbersBetween(n, m));
        Console.WriteLine("Division");
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Total number of divisions: {CountDivisibleBy2(number)}");
    }

    /// <summary>
    /// Calculates the sum of integers between two given integers 'n' and 'm', inclusive.
    /// </summary>
    /// <param name="n">The starting integer.</param>
    /// <param name="m">The ending integer.</param>
    /// <returns>The sum of integers between 'n' and 'm'.</returns>
    public static int CalculateSumOfNumbersBetween(int n, int m) => n == m ? n : n + CalculateSumOfNumbersBetween(n + 1, m);

    /// <summary>
    /// Counts the number of times the input number can be divided evenly by 2.
    /// </summary>
    /// <param name="number">The integer to be divided.</param>
    /// <returns>The count of how many times the number can be divided by 2 evenly.</returns>
    public static int CountDivisibleBy2(int number) => number % 2 != 0 ? 0 : 1 + CountDivisibleBy2(number / 2);
}