//Programmer: Brian Lee
//Date: 05/07/2024

//Title: CSI 120 Lecture Notes 7

using System.Security.Cryptography;

namespace CSI_120_Lecture_Notes_7
{
    internal class Program
    {
        static string[] shoppingList = { "Bread", "Milk", "Eggs", "Apples" };
        static int[] testScores = { 85, 92, 78, 90, 81 };
        static string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        static void Main(string[] args)
        {
            CreatingArray();
            LoopingArray();
            
        }//end of main
        public static void DeclareArray()
        {
            int[] numbers;
            string[] colors;

        }//end of DeclareArray
        public static void CreatingArray()
        {
            int[] age = { 25, 32, 18, 40 };
            string[] names = new string[5];

            Console.WriteLine(string.Join(",",age));
            Console.WriteLine($"the age for index 0 is {age[0]}");
            age[2] = 20;
            Console.WriteLine(string.Join(",", age));

        }//end of CreatingArray
        public static void LoopingArray()
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
                Console.WriteLine(daysOfWeek[i]);
            Console.WriteLine();
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);
        }//end of loopingArray
    }//end of class
}//end of namespace
