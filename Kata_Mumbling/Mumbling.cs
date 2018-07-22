using System;

namespace Kata_Mumbling
{
    using System.Collections.Generic;

    public class Mumbling
    {
        public string Accum(string s)
        {
            if (s.Length == 1)
            {
                return s.ToUpper();
            }

            var i = 1;
            var result = new List<string>();
            foreach (var item in s)
            {
                var r = string.Empty;
                for (var x = 0; x < i; x++)
                {
                    if (x == 0)
                    {
                        r = item.ToString().ToUpper();
                    }
                    else
                    {
                        r += item;
                    }
                }

                result.Add(r);
                i++;
            }

            return string.Join("-", result);
        }
    }
}
