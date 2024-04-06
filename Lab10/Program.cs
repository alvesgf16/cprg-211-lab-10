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
    }

    /// <summary>
    /// Calculates the sum of integers between two given integers 'n' and 'm', inclusive.
    /// </summary>
    /// <param name="n">The starting integer.</param>
    /// <param name="m">The ending integer.</param>
    /// <returns>The sum of integers between 'n' and 'm'.</returns>
    public static int CalculateSumOfNumbersBetween(int n, int m) => n == m ? n : n + CalculateSumOfNumbersBetween(n + 1, m);
}