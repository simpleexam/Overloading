using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal static class Calculator
    {
        public static double Summ(params int[] data)
        {
            double res = 0;
            foreach (int i in data) { res += i; }
            return res;
        }
        public static double Summ(params double[] data)
        {
            double res = 0.0;
            foreach (double i in data) { res += i; }
            return res;
        }
        
    }
}
