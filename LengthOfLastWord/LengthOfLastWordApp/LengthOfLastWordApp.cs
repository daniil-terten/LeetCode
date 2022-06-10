using System;
using System.Collections.Generic;
using System.Linq;

namespace LengthOfLastWord
{
    public class LengthOfLastWordApp
    {
        public int LengthOfLastWord(string s)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            return s.Split(separators, StringSplitOptions.RemoveEmptyEntries).Last().Length;
        }
    }
}
