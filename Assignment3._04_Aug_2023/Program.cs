using System;

namespace Assignment3._04_Aug_2023
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine($"Enter the  {size}  members of the array.");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            Console.WriteLine("Your Array is as follows");
            Console.Write( "[ " );
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");
            // Initialize maximum element
            int max = arr[0];

            // Traverse array elements from second and
            // compare every element with current max
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"Largest in given "
                              + "array is " + max);
        }
    }
}


