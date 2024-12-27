using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Testing_practice
{
    public class MSTestingDemo
    {
        //to check positive or negative
        public bool PosOrNeg(int num)
        {
            bool PONresult = num < 0 ? false : true;
            return PONresult;
        }

        //To check sum of natural numbers
        public int SumOfNaturalNum(int num)
        {
            int sum = (num * (num + 1)) / 2;
            return sum;
        }

        //To check sum of natural numbers with range
        public int SumOfRange(int StartingNum, int EndingNum)
        {
            int sum = 0;
            for(int i=StartingNum; i <= EndingNum; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        //To count vowels in a string
        public int GetVowelCount(string str)
        {
            int vc = 0;
            for(int i =0; i<str.Length; i++)
            {
                if (str[i]=='A'|| str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' || str[i] == 'a' || str[i] == 'e' || str[i] == 'i'
                    || str[i] == 'o' || str[i] == 'u')
                {
                    vc++;
                }
            }
            return vc;
        }
    }
}
