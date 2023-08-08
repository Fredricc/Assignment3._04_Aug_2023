using System;
using System.Collections;
using System.Linq;

namespace Assignment3._04_Aug_2023
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----Array Analyzer------");
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
            Console.WriteLine();
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
            int arrSum = arr.Sum();
            Console.WriteLine( $"Sum of array is {arrSum}");
            Console.WriteLine("Even numbers in the array are: ");

            IEnumerable<int> evenNumbers = arr.Where(x => x%2 == 0);

            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Odd numbers in the array are: ");

            IEnumerable<int> oddNumbers = arr.Where(x => x % 2 != 0);

            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }

            var dict = new Dictionary<int, int>();
            foreach(var value in arr)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else dict[value] = 1;
            }

            foreach( var pair in dict)
            {
                Console.WriteLine("{0} = {1} time(s)", pair.Key, pair.Value);
            }

            Console.WriteLine();
            Console.WriteLine("-----String Analyzer------");
            Console.WriteLine("Enter any string which you want to be printed in reverse:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter a character which you want to be counted in the string:");
            char chr = Convert.ToChar(Console.ReadLine());
            string reverseName = reverse(name);
            Console.WriteLine(name + " written backwards " + reverseName);
            int vcount = 0, ccount = 0, others = 0;

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach( var character in name)
            {
                if(character!= ' ')
                {
                if(!charCount.ContainsKey(character))
                {
                    charCount[character] = 1;
                }
                else
                {
                    charCount[character]++;
                }
                }
            }
            foreach (var character in charCount)
            {
                //if (Convert.ToChar(character) == chr)
                {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
                }
            }

            foreach(char c in name)
            {
                if ((c >= 'a' && c <= 'z') || ( c >= 'A' && c <= 'Z'))
                {
                    if ( c == 'a' || c == 'e' || c == 'i' ||  c == 'o' || c == 'u')
                        vcount++;
                    else if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                        vcount++;
                    else ccount++;
                }
                else others++;
            }

            Console.WriteLine($"\tTotal characters : {name.Length}");
            Console.WriteLine($"\tNo. of Vowels : {vcount}");
            Console.WriteLine($"\tNo. of Consonants : {ccount}");
            Console.WriteLine($"\tNo. of other-alphabets : {others}");

            Console.ReadLine();
        }

        private static string reverse(string? name)
        {
            string r = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                r += name[i];
            }
            return r;
        }
    }
}


