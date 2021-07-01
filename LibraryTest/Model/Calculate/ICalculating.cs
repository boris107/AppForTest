using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest.Model
{
    interface ICalculating
    {        
        int Calculate(int type,int[] parameters);
    }
}
