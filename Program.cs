using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._2._2_second_try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string then press Enter");
            Console.WriteLine();
            string input = Console.ReadLine();
            string output = ReverseVowels(input);
            Console.WriteLine();
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {output}");
        }

        //method to take all the vowels out and replace them in reverse order.

        static string ReverseVowels (string input)
        {
            // Define vowels in a Hashset because it is best suited to membership tests
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }; 

            // using a Stack because it is LIFO
            Stack<char> vowelStorage = new Stack<char>();

            // foreach loop to take vowels and place them into stack
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    vowelStorage.Push(c);
                }
            }

            //rebuilding the string with the reversed vowels
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (vowels.Contains(result[i]))
                {
                    result[i] = vowelStorage.Pop();
                }
            }
            return new string(result);
        }

    }
}
