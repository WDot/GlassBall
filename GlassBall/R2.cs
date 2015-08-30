using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassBall
{
    public class R2<T, U>
    {
        private T x1;
        private U x2;

        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public U X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        R2(T _x, U _y)
        {
            x1 = _x;
            x2 = _y;
        }
    }
}
