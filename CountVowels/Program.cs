using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getVowel("Hello my name is alex and i love people"));
        }
        public static int getVowel(string input)
        {
            int count = 0;
            input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' )
                {
                    count++;
                }
            }
            return count;
        }
    }
}
