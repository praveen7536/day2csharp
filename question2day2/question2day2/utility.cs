using System;
using System.Collections.Generic;
using System.Text;

namespace question2day2
{
    class utility
    {
        public List<string> GetPalindromes(string[] str)
        {
            List<string> str1 = new List<string>();

            foreach (string s in str)
            {
                char[] ch = s.ToCharArray();
                Array.Reverse(ch);
                string revd = new string(ch);
                if (s.Equals(revd))
                {
                    str1.Add(s);
                }
            }

            return str1;
        }
    }
}
