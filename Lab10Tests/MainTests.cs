namespace Lab10.Tests;

public class ProgramTests
{
    [TestCase(1, 10, ExpectedResult = 55)]
    [TestCase(5, 15, ExpectedResult = 110)]
    [TestCase(-5, 5, ExpectedResult = 0)]
    [TestCase(0, 0, ExpectedResult = 0)]
    [TestCase(-10, -1, ExpectedResult = -55)]
    public int CalculateSumOfNumbersBetween_ReturnsCorrectSum(int n, int m)
    {
        // Act
        int result = Program.CalculateSumOfNumbersBetween(n, m);

        // Assert
        return result;
    }
}