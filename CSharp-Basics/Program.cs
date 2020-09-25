using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //string phrase = "Hello World";
            //char grade = 'A';
            //int age = 30;
            //double gpa = 3.2;
            //bool happy = true;

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("Your name is " + userName + ". You are " + userAge + " years old.");
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
