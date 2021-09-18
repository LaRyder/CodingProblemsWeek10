using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class CarExample
    {
        public string ReverseString(string str)
        {
            var sb = new StringBuilder();

            for (var i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
                str.ToLower();
            }

            return sb.ToString();
        }
    }
}
