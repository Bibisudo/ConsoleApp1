namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Birsu";
            customer.LastName = "Caylak";
            customer.City = "Ankara";

            // ya  da şöyle de yazabilirsin:

         Customer customer2 = new Customer
            {
              Id = 2, City= "İstanbul", FirstName = "Batuhan", LastName = "Caylak"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add() 
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update() 
        {
            Console.WriteLine("Customer Updated!");
        }

    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }

    }
}