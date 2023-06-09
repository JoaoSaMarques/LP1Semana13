﻿using System;

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

            //For each number in the GetMinMax
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

            //For each number in the GetMinMax
            foreach (double number in this)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }

            //Return the value
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

            //For each number in the GetMinMax
            foreach (double number in this)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }
        }

        /// <summary>
        /// Get min max4
        /// </summary>
        /// <param name="min"></param>
        /// <param name="GetMinMax4("></param>
        /// <returns></returns>
        public (double min, double max) GetMinMax4()
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            
            //For each number in the GetMinMax
            foreach (double number in this)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }

            //Return the value
            return (min: min, max: max);
        }

        /// <summary>
        /// Print min and max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void PrintMinMax(double min, double max)
        {
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
        }
    }
}
