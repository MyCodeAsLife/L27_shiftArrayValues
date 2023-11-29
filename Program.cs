using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L27_shiftArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = { 1, 2, 3, 4, 5, 6, 7 };
            int shiftLength;

            Console.Write("На сколько порядков нужно сдвинуть массив: ");
            shiftLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nМассив до сдвига:");

            foreach (var item in mainArray)
                Console.Write(item + " ");

            for (int i = 0; i < shiftLength; i++)
            {
                int tempNumber = 0;

                for (int j = 0; j < mainArray.Length; j++)
                {
                    if (j == 0)
                    {
                        tempNumber = mainArray[j + 1];
                        mainArray[j + 1] = mainArray[j];
                    }
                    else if (j < mainArray.Length - 1)
                    {
                        tempNumber += mainArray[j + 1];
                        mainArray[j + 1] = tempNumber - mainArray[j + 1];
                        tempNumber -= mainArray[j + 1];
                    }
                    else if (j == mainArray.Length - 1)
                    {
                        mainArray[0] = tempNumber;
                    }
                }
            }

            Console.WriteLine($"\n\nМассив после сдвига на {shiftLength} порядков в право.");

            foreach (var item in mainArray)
                Console.Write(item + " ");

            Console.WriteLine();
        }
    }
}
