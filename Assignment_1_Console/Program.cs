using System;
using System.Diagnostics;

namespace Assignment_1_Console
{
    class Program
    {
        public static void Main()
        {

            //summary: This method prints all the prime numbers between a and b
            int a = 5, b = 15;
            Console.WriteLine("-------> 1st Assignment:: 1st Question's Answer");
            printPrimeNumbers(a, b);
            Console.ReadLine();
            Console.ReadKey(false);

            //*summary: This method computes the series 1 / 2 – 2!/ 3 + 3!/ 4 – 4!/ 5-- - 
            //n * where !means factorial, i.e., 4! = 4 * 3 * 2 * 1 = 24.
            //Round off the results to *three decimal places. 
            int num = 5;
            double result = getSeriesResult(num);
            Console.WriteLine("-------> 1st Assignment:: 2nd Question's Answer");
            Console.WriteLine("The sum of the series is: " + Math.Round(result,3));
            Console.ReadLine();
            Console.ReadKey(false);


            //*summary: This method prints a triangle using * for n # of lines
            int num_val = 5;
            Console.WriteLine("-------> 1st Assignment:: 3rd Question's Answer");
            printTriangle(num_val);
            Console.ReadLine();
            Console.ReadKey(false);

            //* summary: This method computes the frequency of each element in the array
            int[] Freq = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            Console.WriteLine("-------> 1st Assignment:: 4th Question's Answer");
            computeFrequency(Freq);
            Console.ReadLine();
            Console.ReadKey(false);

            // write your self-reflection here as a comment
            //This assignment gives us chance to code different mathematical terms.
            //It also gives oppurtunity for working with loops/methods/arrays and variables etc.

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                for (int i = x; i <= y; i++)
                {
                    if (!isPrime(i))
                    {
                        Console.WriteLine(i + " is prime");
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception :" + e.Message);
            }
        }

        public static bool isPrime(int num)
        {
            bool flag = false;
            for (int i = 2; i <= num / 2; ++i)
            {
                if (num % i == 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public static double getSeriesResult(int n)
        {
            double output = 0.0;
            try
            {
                int iResult = 1;
                while (iResult <= n)
                {
                    if (iResult % 2 != 0)
                    {
                        output = output + (FactorialNum(iResult) / (iResult + 1.0));
                    }
                    else
                    {
                        output = output - (FactorialNum(iResult) / (iResult + 1.0));
                    }
                    iResult++;
                }
            }
            catch
            {
                Debug.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return output;
        }

        public static int FactorialNum(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * FactorialNum(n - 1));
        }

        public static void printTriangle(int x)
        {
            try
            {
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= (x - i); j++)
                        Console.Write(" ");
                    for (int t = 1; t < i * 2; t++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        
        public static void computeFrequency(int[] Freq)
        {
            int i = 0;
            int n = Freq.Length;
            try
            {
                while (i < n)
                {
                    if (Freq[i] <= 0)
                    {
                        i++;
                        continue;
                    }
                    int elementIndex = Freq[i] - 1;
                    if (Freq[elementIndex] > 0)
                    {
                        Freq[i] = Freq[elementIndex];
                        Freq[elementIndex] = -1;
                    }
                    else
                    {
                        Freq[elementIndex]--;
                        Freq[i] = 0;
                        i++;
                    }
                }
                Console.Write("\nNumber  Frequency" + "\n");
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(Freq[j]) != 0)
                        Console.Write(j + 1 + "         " + Math.Abs(Freq[j]) + "\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }

        }
    }
}