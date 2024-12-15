using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_1262774
{
    interface INewMath
    {
        double ComputeAvgNew(double[] Arr);
        int ComputeAvgRound(double[] Arr);
        double FindMinNew(double[] Arr);
    }

}
