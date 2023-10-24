using System.Runtime.CompilerServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args) 
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");
            //Console.ReadLine();


            //for (int i = 1; i <= 100; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!");

            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}", number);

            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;

            //} while (number >= 0);

            //string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //foreach (var student in students) 
            //{
            //    Console.WriteLine(student);
            //}

            //Asalsa true, asal değilse false.

            if(IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }

            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;

        }
    }
}
