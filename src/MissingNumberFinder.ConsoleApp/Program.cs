namespace MissingNumberFinder.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input examples
            int[] nums1 = { 3, 0, 1 };
            int[] nums2 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            // High-level code depends on abstraction
            IMissingNumberFinder finder = new ArithmeticSeriesMissingNumberFinder();

            Console.WriteLine($"Missing number in [3,0,1]: {finder.FindMissingNumber(nums1)}");
            Console.WriteLine($"Missing number in [9,6,4,2,3,5,7,0,1]: {finder.FindMissingNumber(nums2)}");

            Console.ReadLine();
        }
    }
}

