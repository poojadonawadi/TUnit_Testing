using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Testing_practice
{
    public class Program
    {
        static void Main()
        {
            MSTestingDemo demo = new MSTestingDemo();
            demo.PosOrNeg(3);
            demo.SumOfNaturalNum(5);
            demo.SumOfRange(2, 5);
            demo.GetVowelCount("DotNet");
        }
    }
}
