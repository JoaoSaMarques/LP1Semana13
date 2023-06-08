using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number list
            SuperList numbers = new SuperList { 1.2, 2.3, 4.5, 6.7, 8.9 };

            //Version 1 (Out parameters)
            double min1, max1;
            //This will test Getminmax1 
            numbers.GetMinMax1(out min1, out max1);
            Console.WriteLine("Versão 1:");
            numbers.PrintMinMax(min1, max1);

            //Version 2
            //This will test Getminmax2 (Class/struct)
            var result2 = numbers.GetMinMax2();
            Console.WriteLine("\nVersão 2:");
            numbers.PrintMinMax(result2.min, result2.max);

            //Version 3
            double min3 = double.MaxValue, max3 = double.MinValue;
            //This will test Getminmax3 (Tuple reference)
            numbers.GetMinMax3(ref min3, ref max3);
            Console.WriteLine("\nVersão 3:");
            numbers.PrintMinMax(min3, max3);
        }
    }
}
