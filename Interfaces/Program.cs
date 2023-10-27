namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]

            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlServerCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }



        }
    }
}