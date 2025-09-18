namespace MissingNumberFinder.ConsoleApp
{
    public class ArithmeticSeriesMissingNumberFinder : IMissingNumberFinder
    {
        public int FindMissingNumber(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));
            if (numbers.Length == 0)
                throw new ArgumentException("Array cannot be empty.", nameof(numbers));

            long n = numbers.Length;
            long expectedSum = n * (n + 1) / 2;
            long actualSum = 0;
            foreach (var num in numbers)
                actualSum += num;

            return (int)(expectedSum - actualSum);
        }
    }
}
