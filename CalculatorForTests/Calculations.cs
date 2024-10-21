using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForTests
{
    public class Calculations
    {

        public int Add(int a, int b)
        {
            return a+b;
        }

        public double Div(int v1, int v2)
        {
            if (v2 == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return v1/v2;
        }

        public int Sub(int a, int b)
        {
            return a-b;
        }
        public int Mid(int x, int y, int z)
        { // return median of x, y, z
            int mid = z;
            if (y < z)
            {
                if (x < y)
                {
                    mid = y;
                }
                else if (x < z)
                {
                    mid = x;
                }
            }
            else
            {
                if (x > y)
                {
                    mid = y;
                }
                else if (x > z)
                {
                    mid = x;
                }
            }
            return mid;
        }
    }
}
