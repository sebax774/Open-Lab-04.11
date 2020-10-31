using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            return new string(ch);
        }
    }
}