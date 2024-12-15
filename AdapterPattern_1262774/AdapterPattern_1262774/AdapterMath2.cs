using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_1262774
{
    class AdapterMath2 : IMathTarget
    {
        private ExistingMathAdaptee ema;

        public AdapterMath2()
        {
            ema = new ExistingMathAdaptee();
        }

        public double ComputeAvgNew(double[] Arr)
        {
            if (Arr.Length == 3)
                return ema.ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2]);
            else if (Arr.Length == 4)
                return ema.ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2], (float)Arr[3]);
            else
                throw new Exception("Array size is not currently supported for ComputeAvg");
        }

        public int ComputeAvgRound(double[] Arr)
        {
            if (Arr.Length == 3)
                return (int)Math.Round(ema.ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2]));
            else if (Arr.Length == 4)
                return (int)Math.Round(ema.ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2], (float)Arr[3]));
            else
                throw new Exception("Array size is not currently supported for ComputeAvg");
        }

        public double FindMinNew(double[] Arr)
        {
            if (Arr.Length == 3)
                return ema.FindMin((float)Arr[0], (float)Arr[1], (float)Arr[2]);
            else if (Arr.Length == 4)
                return ema.FindMin((float)Arr[0], (float)Arr[1], (float)Arr[2], (float)Arr[3]);
            else
                throw new Exception("Array size is not currently supported for FindMin");
        }
    }
}

