using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviation
{
    public class StandardDeviationCalculations
    {
        public int n;
        public double m;
        public List<long> numbers;

        private double standardDeviation;
        private long sum;

        public double StandardDeviation
        {
            get
            {
                return standardDeviation;
            }
        }

        public StandardDeviationCalculations()
        {
            n = 0;
            m = 0.0;
            numbers = new List<long>();
            standardDeviation = 0.0;
            sum = 0;
        }

        public void ParseLine(string line)
        {
            var fieldInfo = line.Split(Properties.Resources.FieldDelimiter);
            //Check if teh line has valid format
            if (fieldInfo.Length != 2)
            {
                Console.WriteLine(string.Format("{0} is not valid", line));
                return;
            }

            //Check if the date has valid format
            var dateParts = fieldInfo[0].Split("/");
            if (dateParts.Length != 3)
            {
                Console.WriteLine(string.Format("Date for {0} is not valid", line));
                return;
            }

            if (dateParts[2] == "2000")
            {
                //Console.WriteLine(fieldInfo[1]);
                numbers.Add(Convert.ToInt64(fieldInfo[1]));
                n++;
                sum = sum + Convert.ToInt64(fieldInfo[1]);
            }

        }

        public void CalculateMeanValue()
        {
            m = sum / n;
        }

        public void Calculate()
        {
            double sum = 0;
            for(int i=0; i< numbers.Count; ++i)
            {
                sum = sum + Math.Pow(numbers[i] - m,2);
            }

            standardDeviation = Math.Sqrt(sum / n);
        }
    }
}
