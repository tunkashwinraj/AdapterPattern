using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_1262774
{
    class ExistingMathAdapteeDerived : ExistingMathAdaptee
    {
        public float FindMax(float a, float b, float c)
        {
            float max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
    }
}

