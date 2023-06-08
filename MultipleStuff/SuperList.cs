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
    }
}
