//using System.Text;

//namespace SecondLessonCS
//{
//    enum Status
//    {
//        Online, Offline, Unknown
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] statusEnum = Enum.GetNames(typeof(Status));

//            foreach (string status in statusEnum)
//            {
//                Console.WriteLine(status);
//            }


//            //Status userStatus = Status.Online;

//            StringBuilder sb = new StringBuilder();

//            sb.Append("Hello");
//            sb.Append(" world");
//            sb.Append("\nI Love C++");
//            sb.Append("\nI Love C#");

//            string str = sb.ToString();

//            //str += "hello";
//            //str += " world";
//            //str += "\nI Love C++";
//            //str += "\nI Love C#";

//            //string str = null;
//            //string str = "";
//            //string str = "Hello wordl";
//            //string str = new string('c', 10);

//            //Console.WriteLine(str[5]);

//            //str.Remove()
//            //str.Replace('H', 'h');

//            //string str = "hello" + " " + "world";
//            //Console.WriteLine(str);

//            //Console.WriteLine(str.ToLower());
//            //Console.WriteLine(str.Insert(5, "SUMSTR"));

//            //string[] words = str.Split(' ');
//            //Console.WriteLine(words.Length);

//            //int[,] arr2d =
//            //{
//            //    {1,2,3 },
//            //    {4,5,6 }
//            //};
//            //int[,,] arr3d = new int[1, 1, 3]
//            //{
//            //    {
//            //        {1,2,3 },
//            //    }
//            //};

//            //Console.WriteLine(arr2d.Rank);
//            //Console.WriteLine(arr2d.Length);

//            //Console.WriteLine(arr2d.GetLength(0));

//            //object[] objects = { 1, 6.7, false, 'c', "str" };

//            //int[] numbers = { 15, 2347, 228, 303 };

//            //string numbersStr = string.Join(", ", numbers);

//            //Console.WriteLine(numbersStr);

//            //string str = "        hello         ";
//            //Console.WriteLine(str);
//            //Console.WriteLine(str.Trim());
//            //Console.WriteLine(str.TrimStart());
//            //Console.WriteLine(str.TrimEnd());


//            //int[] copy = new int[4];
//            //numbers.CopyTo(copy,0);

//            //copy[0] = -5;
//            //foreach (int number in numbers)
//            //{
//            //    Console.WriteLine(number);
//            //}
//            //Array.Sort(numbers);

//            //int index = Array.BinarySearch(numbers, 15);

//            //Console.WriteLine(index);

//            //foreach (int i in numbers)
//            //{
//            //    Console.Write($"{i},");
//            //}

//            //Console.WriteLine();

//            ////Array.Reverse(numbers);
//            //Array.Clear(numbers);

//            //foreach (int i in numbers)
//            //{
//            //    Console.Write($"{i},");
//            //}

//            ////int[] numbers = new int[10];

//            //Console.WriteLine(numbers.Length);

//            //Console.WriteLine(numbers[0].ToString());

//            //Console.WriteLine(numbers[0]);
//        }
//    }
//}
