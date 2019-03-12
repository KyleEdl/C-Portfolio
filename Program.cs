using System;
using System.IO;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Hello! My name is Fizz Buzz!");
            Console.WriteLine("Let's get started by entering your first name.");
            string firstname = (Console.ReadLine());
            Console.WriteLine("Hello, {0}", firstname + " what is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Great! So your name will be, {0}", firstname + " " + lastname + ".");
        
                Console.WriteLine("Awesome! Well if you don't mind. Please enter a number.");
                int number = Convert.ToInt32(Console.ReadLine());
                


            //string product = firstname + Environment.NewLine + firstname + Environment.NewLine + firstname + Environment.NewLine + firstname + Environment.NewLine + lastname;
            for (int i = 1; i <= number; i++)
            {
                Console.Write(firstname + " ");
                if(i % 5 == 0)
                {
                    Console.Write(lastname);
                }
                Console.WriteLine();
            }
                Console.WriteLine("TaDa!");
                Console.WriteLine("Press any key to leave me... sad... alone...");
                Console.ReadLine();
        }
    }
}
