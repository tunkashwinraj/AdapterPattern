using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_1262774
{
    class MathAdapterTwoWay : INewMath, IExistingMath
    {
        private ExistingMathAdaptee ema;
        private ExistingMathAdapteeDerived emad;

        public MathAdapterTwoWay()
        {
            ema = new ExistingMathAdaptee();
            emad = new ExistingMathAdapteeDerived();
        }

        // IExistingMath Methods
        public double ComputeAvg(float a, float b, float c)
        {
            return ema.ComputeAvg(a, b, c);
        }

        public double ComputeAvg(float a, float b, float c, float d)
        {
            return ema.ComputeAvg(a, b, c, d);
        }

        public double FindMin(float a, float b, float c)
        {
            return ema.FindMin(a, b, c);
        }

        public double FindMin(float a, float b, float c, float d)
        {
            return ema.FindMin(a, b, c, d);
        }

        // INewMath Methods
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

        public double FindMax(double[] Arr)
        {
            if (Arr.Length == 3)
                return emad.FindMax((float)Arr[0], (float)Arr[1], (float)Arr[2]);
            else
                throw new Exception("Array size > 3 not supported");
        }
    }
}

