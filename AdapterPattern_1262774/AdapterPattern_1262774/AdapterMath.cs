using System;

namespace AdapterPattern_1262774
{
    class AdapterMath : ExistingMathAdaptee, INewMath
    {
        public double ComputeAvgNew(double[] Arr)
        {
            if (Arr.Length == 3)
                return ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2]);
            else if (Arr.Length == 4)
                return ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2], (float)Arr[3]);
            else
                throw new Exception("Array size is not currently supported for ComputeAvg");
        }

        public int ComputeAvgRound(double[] Arr)
        {
            if (Arr.Length == 3)
                return (int)Math.Round(ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2]));
            else if (Arr.Length == 4)
                return (int)Math.Round(ComputeAvg((float)Arr[0], (float)Arr[1], (float)Arr[2], (float)Arr[3]));
            else
                throw new Exception("Array size is not currently supported for ComputeAvgRound");
        }

        public double FindMinNew(double[] Arr)
        {
            if (Arr.Length == 3)
                return FindMin((float)Arr[0], (float)Arr[1], (float)Arr[2]);
            else if (Arr.Length == 4)
                return FindMin((float)Arr[0], (float)Arr[1], (float)Arr[2], (float)Arr[3]);
            else
                throw new Exception("Array size is not currently supported for FindMin");
        }
    }
}
