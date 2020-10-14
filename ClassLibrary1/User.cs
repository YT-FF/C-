using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        private int a, b, x;
        public User(int a,int b,int x)
        {
            a = a;
            b = b;
            x = x;
            if ((a > 1) && (b == 0))
            {
                x = x / a;
            }
            if ((a == 2) || (x > 1))
            {
                x += 1;
            }
        }
        
    }
}
