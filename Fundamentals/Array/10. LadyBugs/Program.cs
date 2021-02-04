using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            bool[] field = new bool[sizeOfField];

            int[] inputLadyBugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var index in inputLadyBugs)
            {
                if (index < 0 || index >= field.Length)
                {
                    continue;
                }
                field[index] = true;
            }

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end")
                {
                    break;
                }

                string[] inputParts = input.Split();

                int index = int.Parse(inputParts[0]);
                string direction = inputParts[1];
                int length = int.Parse(inputParts[2]);

                //proverqvame dali indexa e validen
                //dali vuv kletkata ima kalinka
                
                if (index < 0 || index >= field.Length || !field[index])
                {
                    continue;
                }

                // 2. index + length => filled cell => find empty cell
                field[index] = false;

                while (true)
                {
                    if (direction == "right")
                    {
                        index += length;
                    }
                    else
                    {
                        index -= length;
                    }

                    // index + length => cell outside of the field
                    if (index >= field.Length || index < 0 )
                    {
                        break;
                    }
                    // index + length => empty cell
                    if (!field[index])
                    {
                        field[index] = true;
                        break;
                    }
   
                }
            }

            foreach (var cell in field)
            {
                if (cell)
                {
                    Console.Write("1 ");
                }
                else
                {

                    Console.Write("0 ");
                }
            }

        }
    }
}
