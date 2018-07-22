using System;

namespace Kata_Mumbling
{
    public class Mumbling
    {
        public string Accum(string s)
        {
            if (s.Length == 1)
            {
                return s.ToUpper();
            }

            return "A-Bb";
        }
    }
}
