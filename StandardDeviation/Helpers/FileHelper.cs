using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardDeviation.Helpers
{
    public static class FileHelper
    {
        static public void ReadFromFile(StandardDeviationCalculations st)
        {
            try
            {
                if (!File.Exists(Properties.Resources.FilePath))
                {
                    Console.WriteLine(string.Format("File {0} doens't exist", Properties.Resources.FilePath));
                    return;
                }

                string line;

                StreamReader file = new StreamReader(Properties.Resources.FilePath);

                while ((line = file.ReadLine()) != null)
                {
                    try
                    {
                        st.ParseLine(line);
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Error while processing the line " + line);
                        throw new Exception("Error while processing the line " + line, ex);
                    }
                }

                file.Close();

                st.CalculateMeanValue();
            }catch(Exception ex)
            {
                Console.WriteLine("Error while processing the file " + ex.Message);
            }
           
        }

    }
}
