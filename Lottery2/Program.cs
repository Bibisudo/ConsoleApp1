int columnNumber;
Console.Write("Kolon sayısı giriniz:");
columnNumber= int.Parse(Console.ReadLine());

if (columnNumber > 0 && columnNumber < 8)
{
Random random = new Random();
    int[] column = new int[6];
    for (int i = 0; i < columnNumber; i++) // i eğer columnNumber'dan küçükse sen bu foru çalıştır. koışul yazdığın yer ortası.
    {
        for (int j = 0; j < column.Length; j++)
        {   
            int randomNumber = random.Next(1,49);
            while (column.Contains(randomNumber))
            {
                randomNumber = random.Next(1, 49);
            }
            column[j] = randomNumber;

        }
        foreach (int number in column)
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        Console.WriteLine("***********");
    }
}
else
{
    Console.WriteLine("Hatasız kul olmaz! Bir daha dene!");
}




