using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest.Model
{
    class MaxMin : ICalculating
    {
        public int Calculate(int type, int[] parameters)
        {
            int R = 0;
            if (type == 3)
                R = parameters.Max();
            else if (type == 4)
                R = parameters.Min();
            return R;
        }
    }
}
