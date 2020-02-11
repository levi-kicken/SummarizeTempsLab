using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;

            Console.WriteLine("Enter filename");

            fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                Console.WriteLine("File Exists");

                Console.WriteLine("Enter Threshold");

                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempCount = 0;

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string line = sr.ReadLine();
                    int temp;

                    while (line != null)
                    {
                        temp = int.Parse(line);

                        sumTemps += temp;

                        tempCount += 1;

                        if (temp >= threshold)
                        {
                            numAbove += 1;
                        }

                        else
                        {
                            numBelow += 1;
                        }
                        line = sr.ReadLine();
                    }


                }

                Console.WriteLine("Temperatures Above = " + numAbove);

                Console.WriteLine("Temperatures Below = " + numBelow);

                Console.WriteLine("Average Temperature = " + sumTemps/tempCount);
            }

            else
            {
                Console.WriteLine("File Does Not Exist");
            }
            // temperature data is in temps.txt
        }
    }
}
