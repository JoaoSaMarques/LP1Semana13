using System;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        /// <summary>
        /// Get min max1
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void GetMinMax1(out double min, out double max)
        {
            min = double.MaxValue;
            max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }
        }

        /// <summary>
        /// Get min max2
        /// </summary>
        /// <param name="min"></param>
        /// <param name="GetMinMax2("></param>
        /// <returns></returns>
        public (double min, double max) GetMinMax2()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }

            return (min, max);
        }

        /// <summary>
        /// Get min max3
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void GetMinMax3(ref double min, ref double max)
        {
            min = double.MaxValue;
            max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }
        }
        
    }
}
