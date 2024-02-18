using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole.obj
{
    class MyComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if(x<y) return 1;
            if(x>y) return -1;
            return 0;
        }
    }
}