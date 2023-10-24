namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20);
            int number1;
            int number2 = 100;
            var result2 = Add3(out number1, number2);
           
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }
        static void Add()
        { Console.WriteLine("Added!");

        }
        static int Add2(int number1, int number2 = 30)
        // Default değerler metodun en sonunda olması gerekiyor.
        {
            var result = number1 + number2;
            return result;
        }
        //Reften farkı int number1;'e değer atamak zorunda olmadan çalışabilmesi ancak outlarda aşağıda metodun içinde değerin bir kere set edilmesi gerekiyor. number1 = 30; gibi.
        static int Add3(out int number1,int number2)
        {
          number1 = 30;
          return number1 + number2;

        }
    }
}
