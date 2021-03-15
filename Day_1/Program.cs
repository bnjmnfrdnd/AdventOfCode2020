using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("../../Day_1_Puzzle.txt");
                String line = sr.ReadLine();
                string[] inputTemp = null;
                List<string> inputList = new List<string>();

                while (line != null)
                {
                    inputTemp = line.Split('\n');
                    inputList.Add(inputTemp[0]);
                    line = sr.ReadLine();
                }

                for (int x = 0; x < inputList.Count; x++)
                {
                    for (int y = 0; y < inputList.Count; y++)
                    {
                        if (Int32.Parse(inputList[x]) + Int32.Parse(inputList[y]) == 2020)
                        {
                            Console.WriteLine("2020: " + Int32.Parse(inputList[x]) + " + " + Int32.Parse(inputList[y]));
                            Console.WriteLine("Answer: " + Int32.Parse(inputList[x]) * Int32.Parse(inputList[y]));
                            Console.ReadLine();

                            // Answers
                            // 833 + 1187 = 2020
                            // 833 * 1187 = 988771
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
