using MissingNumberFinder.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MissingNumberFinder.Tests;

[TestClass]
public sealed class MissingNumberFinderTest
{
    private IMissingNumberFinder _finder = null!;

    [TestInitialize]
    public void Setup()
    {
        // Use the ArithmeticSeriesMissingNumberFinder implementation
        _finder = new ArithmeticSeriesMissingNumberFinder();
    }

    [TestMethod]
    public void TestMissingNumber_SmallArray()
    {
        int[] numbers = { 3, 0, 1 };
        int expected = 2;

        int actual = _finder.FindMissingNumber(numbers);

        Assert.AreEqual(expected, actual, "The missing number should be 2.");
    }

    [TestMethod]
    public void TestMissingNumber_LargeArray()
    {
        int[] numbers = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        int expected = 8;

        int actual = _finder.FindMissingNumber(numbers);

        Assert.AreEqual(expected, actual, "The missing number should be 8.");
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentNullException))]
    public void TestMissingNumber_NullArray()
    {
        _finder.FindMissingNumber(null!);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void TestMissingNumber_EmptyArray()
    {
        _finder.FindMissingNumber(new int[0]);
    }
}
