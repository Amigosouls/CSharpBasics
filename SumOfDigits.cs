using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
     class SumOfDigits
    {
        int userNum = 0;
        public SumOfDigits(int num)
        {
            this.userNum = num;
        }

        public int findSumOfDigits()
        {
            int sum = 0;
            while(userNum>0)
            {
                int rem = userNum % 10;
                sum += rem;
                userNum = userNum / 10;
            }
            return sum;
        }

    }
}
