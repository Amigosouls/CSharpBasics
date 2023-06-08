using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class Multiples
    {
        int range;
        public Multiples(int num) 
        {
            this.range = num;
        }

        public int findSumOfMultiples()
        {
            int sum = 0;
            for(int i=1; i<=range; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
