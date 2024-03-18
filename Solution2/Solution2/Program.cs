using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
        int max = FindMaximumValue(numbers);
        Console.WriteLine($"The max value is: {max}");

    }

    static double CalculateAverage(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty", nameof(nums));
            }
        double sum = 0;
        foreach (int num in nums){
            sum += num;
        }
        return sum / nums.Length;
    }
    static int FindMaximumValue(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(nums));
        }

        int maxValue = nums[0];
        foreach (int num in nums)
        {
            if (num > maxValue)
                {
                maxValue = num;
                }
        }
        return maxValue;
    }

    
}

