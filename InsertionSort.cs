
using System;
 public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter numbers to be sorted (separated by spaces):");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
             InsertionSort(numbers);
             Console.WriteLine("Sorted array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
     public static void InsertionSort(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
         int n = array.Length;
         for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;
             while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
             array[j + 1] = key;
        }
    }
}