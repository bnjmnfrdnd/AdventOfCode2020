using System;
using System.IO;
using System.Collections.Generic;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../Day_2_Puzzle.txt");
            String line = sr.ReadLine();

            char[] delimArray = { '-', ' ', ':' };
            char[] letterArray;
            string[] inputTemp;
            char requiredCharacter;
            int minimumRequirement;
            int maximumRequirement;
            int requiredCharacterPositionOne;
            int requiredCharacterPositionTwo;
            string password;
            int requirementCounter;
            int part1ValidPasswordCounter = 0;
            int part2ValidPasswordCounter = 0;

            while (line != null)
            {
                inputTemp = line.Split(delimArray[0]);
                minimumRequirement = Int32.Parse(inputTemp[0]);
                requiredCharacterPositionOne = Int32.Parse(inputTemp[0]);
                inputTemp = inputTemp[1].Split(delimArray[1]);
                maximumRequirement = Int32.Parse(inputTemp[0]);
                requiredCharacterPositionTwo = Int32.Parse(inputTemp[0]);
                inputTemp = inputTemp[1].Split(delimArray[2]);
                requiredCharacter = char.Parse(inputTemp[0]);
                inputTemp[0] = line.Substring(line.LastIndexOf(' ') + 1);
                password = inputTemp[0];

                if (password.Contains(requiredCharacter.ToString()))
                {
                    requirementCounter = 0;
                    letterArray = password.ToCharArray();

                    //Part 1 

                    foreach (char letter in letterArray)
                    {
                        if (letter == requiredCharacter)
                        {
                            requirementCounter++;
                        }
                    }

                    if (requirementCounter >= minimumRequirement && requirementCounter <= maximumRequirement)
                    {
                        part1ValidPasswordCounter++;
                    }

                    //Part 2

                    if (letterArray[requiredCharacterPositionOne - 1] == requiredCharacter && letterArray[requiredCharacterPositionTwo - 1] != requiredCharacter)
                    {
                        part2ValidPasswordCounter++;
                    } 
                    else if (letterArray[requiredCharacterPositionTwo - 1] == requiredCharacter && letterArray[requiredCharacterPositionOne - 1] != requiredCharacter)
                    {
                        part2ValidPasswordCounter++;
                    }
                }

                Console.WriteLine("Minimum requirement/Position 1: " + minimumRequirement);
                Console.WriteLine("Maximum requirement/Position 2: " + maximumRequirement);
                Console.WriteLine("Required character: " + requiredCharacter);
                Console.WriteLine("Password: " + password);
                line = sr.ReadLine();
            }

            Console.WriteLine("Valid passwords (part 1): " + part1ValidPasswordCounter);
            Console.WriteLine("Valid passwords (part 2): " + part2ValidPasswordCounter);
            Console.ReadLine();
        }
    }
}