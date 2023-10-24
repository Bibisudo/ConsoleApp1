namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Add()
        { Console.WriteLine("Added!");
        
        }
        static int Add2(int number1, int number2=30) 
            // Default değerler metodun en sonunda olması gerekiyor.
        { 
            var result = number1 + number2;
            return result;
        }
    }
}
