using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
     class Reverse
    {
        string userString;
        public Reverse(string str)
        {
            this.userString = str;
        }
        public string reversedString()
        {
            string reversed = "";
            for(int i= userString.Length - 1; i >= 0; i--)
            {
                reversed += userString[i];
            }
            return reversed;
        }
    }
}
