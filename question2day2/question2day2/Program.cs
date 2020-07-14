
using System;
using System.Collections.Generic;

namespace question2day2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            utility u1 = new utility();
            string[] str2 = { "mom", "honey", "saippuakivikauppias" };
            Console.WriteLine("String before palindrome check");
            foreach (var item in str2)
            {
                Console.WriteLine(item);
            }
            List<string> str1 = new List<string>();
            str1 = u1.GetPalindromes(str2);
            Console.WriteLine("-------++++++------");
            Console.WriteLine("String After palindrome check");
            foreach (var item in str1)
            {
                Console.WriteLine(item);

            }

            
        }
    }
}
