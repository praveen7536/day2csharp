using System;
using System.Collections.Generic;
using System.Text;

namespace question1
{
    class utility
    {
        public static string LastWord(int pos, string str, char ch)
        {
            string[] wordlist = str.Split(ch);
            string res = wordlist[pos];
            if (res != null && pos < str.Length)
            {
                return res;
            }
            else
            {
                return "NO VALID STRING PRESENT";
            }
        }

    }
}
