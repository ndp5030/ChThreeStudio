using System;
using System.Collections.Generic;
using System.Text;

namespace ChThreeStudio
{
    internal class CharCount
    {
        public static Dictionary<char, int> myCount()
        {
            Dictionary<char, int> output = new Dictionary<char, int>();
            string input;
            Console.WriteLine("Please enter a string: ");
            input = Console.ReadLine();

            foreach (char character in input)
            {
                if (!output.ContainsKey(character))
                {
                    output.Add(character, 1);
                } else
                {
                    output[character]++;
                }
            }
            return output;
        }
    }
}
