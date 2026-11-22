//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SecondLessonCS
//{
//    internal class Practice
//    {
//        static void Main(string[] args) {
//            // task 1
//            /*
//            int[] array = { 1, 2, 2, 3, 4, 5, 5, 6, 7 };

//            int evenCount = 0;
//            int oddCount = 0;
//            int uniqueCount = 0;

//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] % 2 == 0)
//                    evenCount++;
//                else
//                    oddCount++;

//                int sameCount = 0;
//                for (int j = 0; j < array.Length; j++)
//                {
//                    if (array[i] == array[j])
//                        sameCount++;
//                }

//                if (sameCount == 1)
//                    uniqueCount++;
//            }

//            Console.WriteLine("Even elements: " + evenCount);
//            Console.WriteLine("Odd elements: " + oddCount);
//            Console.WriteLine("Unique elements: " + uniqueCount);
//            */
//            // task 2
//            /*
//            int[] array = { 12, 4, 7, 23, 47, 6, 15, 3 };

//            Console.Write("Enter a number: ");
//            int limit = Convert.ToInt32(Console.ReadLine());

//            int count = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] < limit)
//                {
//                    count++;
//                }
//            }

//            Console.WriteLine("Elements less than " + limit + ": " + count);
//            */
//            // task 3
//            /*
//            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

//            Console.Write("Enter 1st number: ");
//            int a = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter 2nd number: ");
//            int b = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter 3rd number: ");
//            int c = Convert.ToInt32(Console.ReadLine());

//            int count = 0;
//            for (int i = 0; i < array.Length - 2; i++)
//            {
//                if (array[i] == a && array[i + 1] == b && array[i + 2] == c)
//                    count++;
//            }

//            Console.WriteLine("Sequence count: " + count);
//            */
//            // task 4
//            /*
//            int[] arrayM = { 1, 2, 4, 4, 5, 8, 10 };
//            int[] arrayN = { 2, 4, 4, 6, 8, 12 };

//            int[] temp = new int[arrayM.Length];
//            int resultCount = 0;

//            for (int i = 0; i < arrayM.Length; i++)
//            {
//                bool foundInN = false;
//                for (int j = 0; j < arrayN.Length; j++)
//                {
//                    if (arrayM[i] == arrayN[j])
//                    {
//                        foundInN = true;
//                        break;
//                    }
//                }

//                bool alreadyAdded = false;
//                for (int k = 0; k < resultCount; k++)
//                {
//                    if (temp[k] == arrayM[i])
//                    {
//                        alreadyAdded = true;
//                        break;
//                    }
//                }

//                if (foundInN && !alreadyAdded)
//                {
//                    temp[resultCount] = arrayM[i];
//                    resultCount++;
//                }
//            }

//            int[] result = new int[resultCount];
//            for (int i = 0; i < resultCount; i++)
//            {
//                result[i] = temp[i];
//                Console.Write(result[i] + " ");
//            }
//            */
//            // task 5
//            /*
//            Console.Write("Enter a sentence: ");
//            string sentence = Console.ReadLine();

//            string[] words = sentence.Split(' ');

//            Console.Write("Result: ");
//            for (int i = 0; i < words.Length; i++)
//            {
//                string word = words[i];

//                for (int j = word.Length - 1; j >= 0; j--)
//                {
//                    Console.Write(word[j]);
//                }

//                Console.Write(" ");
//            }
//            */
//            // task 6
//            /*
//            Console.Write("Enter a sentence: ");
//            string sentence = Console.ReadLine().ToLower();

//            string vowels = "aeiouy";
//            int count = 0;

//            for (int i = 0; i < sentence.Length; i++)
//            {
//                char letter = sentence[i];

//                if (vowels.Contains(letter))
//                    count++;
//            }

//            Console.WriteLine("Vowels count: " + count);
//            */
//            // task 7
//            Console.Write("Enter text: ");
//            string text = Console.ReadLine();

//            Console.Write("Enter word to search: ");
//            string word = Console.ReadLine();

//            int count = 0;

//            for (int i = 0; i <= text.Length - word.Length; i++)
//            {
//                bool match = true;

//                for (int j = 0; j < word.Length; j++)
//                {
//                    if (text[i + j] != word[j])
//                    {
//                        match = false;
//                        break;
//                    }
//                }

//                if (match)
//                    count++;
//            }

//            Console.WriteLine("Search result: " + count);
//        }
//    }
//}
