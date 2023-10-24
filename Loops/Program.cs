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

            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students) 
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        } 
    }
}
