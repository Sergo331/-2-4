using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMin = 1;
            int numberMax = 101;
            int randomNumber;
            int numberSum = 0;
            int nemberMultiple1 = 3;
            int nemberMultiple2 = 5;
            Random random = new Random();

            randomNumber = random.Next(numberMin, numberMax);
            Console.WriteLine(randomNumber);

            for (int i = 0; i < randomNumber; i++)
            {
                if (i % nemberMultiple1 == 0 || i % nemberMultiple2 == 0)
                {
                    numberSum += i;
                }
            }

            Console.WriteLine($"Сумма всех чисел, которые кратны {nemberMultiple1} или {nemberMultiple2}:");
            Console.WriteLine(numberSum);


        }
    }
}
