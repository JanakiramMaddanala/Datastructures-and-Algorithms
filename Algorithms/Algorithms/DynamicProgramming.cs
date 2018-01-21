using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DynamicProgramming
    {
        bool IsFirstTime = true;
        int[] buffer;
        public int Solve(int n)
        {
            if (IsFirstTime)
            {
                buffer = new int[n+1];
                IsFirstTime = false;
            }
            // base case
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (buffer[n] != 0)
            {
                return buffer[n];
            }

            buffer[n] = Solve(n - 1) + Solve(n - 3) + Solve(n - 5);
            return buffer[n];
        }
    }
}
