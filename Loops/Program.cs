namespace Loops
{
    class Program
    {
        static void Main(string[] args) 
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();


            for (int i = 1; i <= 100; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();
        } 
    }
}
