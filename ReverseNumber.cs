using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ReverseNumber
    {
        int userInput;
        string revNum;
        public ReverseNumber(int num) {
            this.userInput = num;
        }
        public int findReverse()
        {
            while(userInput>0)
            {
                int rem = userInput % 10;
                revNum += rem.ToString();
                userInput = userInput / 10;
            }
            return Convert.ToInt32(revNum);
        }
    }
}
