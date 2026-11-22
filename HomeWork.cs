using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLessonCS
{
    internal class HomeWork
    {
        static void Main(string[] args)
        {
            // task 1
            /*
            Random rand = new Random();
            int[,] array = new int[5, 5];

            int minVal = 101;
            int maxVal = -101;
            int minIndex = 0;
            int maxIndex = 0;
            int currentIndex = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-100, 101);
                    Console.Write(array[i, j] + "\t");

                    if (array[i, j] < minVal)
                    {
                        minVal = array[i, j];
                        minIndex = currentIndex;
                    }

                    if (array[i, j] > maxVal)
                    {
                        maxVal = array[i, j];
                        maxIndex = currentIndex;
                    }

                    currentIndex++;
                }
                Console.WriteLine();
            }

            int start = minIndex < maxIndex ? minIndex : maxIndex;
            int end = minIndex > maxIndex ? minIndex : maxIndex;

            int sum = 0;
            currentIndex = 0;

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (currentIndex > start && currentIndex < end)
                        sum += array[i, j];
                    currentIndex++;
                }

            Console.WriteLine("Min: " + minVal + ", Max: " + maxVal);
            Console.WriteLine("Sum between min and max: " + sum);
            */
            // task 2
            /*
            Console.Write("Enter an expression (+ and - only): ");
            string input = Console.ReadLine();

            int result = 0;
            int currentNumber = 0;
            char sign = '+';

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch >= '0' && ch <= '9')
                    currentNumber = currentNumber * 10 + (ch - '0');
                else if (ch == '+' || ch == '-')
                {
                    if (sign == '+')
                        result += currentNumber;
                    else
                        result -= currentNumber;

                    currentNumber = 0;
                    sign = ch;
                }
            }

            if (sign == '+')
                result += currentNumber;
            else
                result -= currentNumber;

            Console.WriteLine("Result: " + result);
            */
            //task 3
            string text = "To be, or not to be, that is the question,\n" +
              "Whether 'tis nobler in the mind to suffer\n" +
              "The slings and arrows of outrageous fortune,\n" +
              "Or to take arms against a sea of troubles,\n" +
              "And by opposing end them? To die: to sleep;\n" +
              "No more; and by a sleep to say we end\n" +
              "The heart-ache and the thousand natural shocks\n" +
              "That flesh is heir to, 'tis a consummation\n" +
              "Devoutly to be wish'd. To die, to sleep";

            Console.Write("Enter forbidden word: ");
            string forbidden = Console.ReadLine();

            string stars = new string('*', forbidden.Length);
            int count = 0;
            string result = "";
            int i = 0;

            while (i <= text.Length - forbidden.Length)
            {
                bool match = true;
                for (int j = 0; j < forbidden.Length; j++)
                    if (text[i + j] != forbidden[j])
                    {
                        match = false;
                        break;
                    }

                if (match)
                {
                    result += stars;
                    count++;
                    i += forbidden.Length;
                }
                else
                {
                    result += text[i];
                    i++;
                }
            }

            while (i < text.Length)
            {
                result += text[i];
                i++;
            }

            Console.WriteLine("\nResult:\n" + result);
            Console.WriteLine("\nStatistics:");
            Console.WriteLine(count + " replacements of word " + forbidden);
        }
    }
}
