using System;
using System.Collections.Generic;

namespace ChThreeStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            // used for first part of studio
            // Dictionary <char, int> countedChars = CharCount.myCount(myString);
            // used for bonuses
            Dictionary<char, int> countedChars = CharCount.myCount();
            Console.WriteLine(countedChars);

            foreach (KeyValuePair<char, int> kvp in countedChars)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            

        }
    }
}
