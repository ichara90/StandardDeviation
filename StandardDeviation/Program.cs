using StandardDeviation.Helpers;
using System;

namespace StandardDeviation
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardDeviationCalculations st = new StandardDeviationCalculations();

            FileHelper.ReadFromFile(st);
            Console.WriteLine("There are {0} numbers", st.n);
            Console.WriteLine("μ is {0}", st.m);
            st.Calculate();
            Console.WriteLine("Standard Deviation is {0}", st.StandardDeviation);
            Console.ReadLine();
        }
    }
}
