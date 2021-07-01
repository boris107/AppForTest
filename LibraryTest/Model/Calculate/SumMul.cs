using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest.Model
{
    class SumMul : ICalculating
    {
        public int Calculate(int type, int[] parameters)
        {
            int R = 0;
            if (type == 2)
                R = 1;
            foreach (var parameter in parameters)
            {
                if (type == 1)
                    R += parameter;
                else if (type == 2)
                    R *= parameter;
            }
            return R % 255;
        }
    }
}
