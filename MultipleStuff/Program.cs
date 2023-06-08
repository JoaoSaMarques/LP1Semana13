using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number list
            SuperList numbers = new SuperList { 1.2, 2.3, 4.5, 6.7, 8.9 };

            //Version 1
            double min1, max1;
            //This will test Getminmax1
            numbers.GetMinMax1(out min1, out max1);
            Console.WriteLine("Versão 1:");
            numbers.PrintMinMax(min1, max1);
        }
    }
}
