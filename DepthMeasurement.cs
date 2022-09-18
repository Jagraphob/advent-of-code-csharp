namespace adventOfCode
{
    public class DepthMeasurement
    {
        private readonly int[] _data;

        public DepthMeasurement(int[] data)
        {
            _data = data;
        }

        public int CountDeptIncrease(int windowSize = 1)
        {
            int count = 0;
            for(int i = 0; i < _data.Length - windowSize; i++)
            {
                int sumA = 0;
                int sumB = 0;

                for(int j = 0; j <= windowSize - 1; j++)
                {
                    sumA = sumA + _data[i+j];
                    sumB = sumB + _data[i+j+1];
                }

                if(sumA < sumB)
                {
                    count++;
                }
            }

            return count;
        }
    }

}