using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndivCustomer customer = new IndivCustomer { Id = 1,CustomerNum = "12345",FName = "engin",LName = "demiroğ",TcNum = "12345678910" };
            CorpCustomer customer2 = new CorpCustomer { Id = 2, CustomerNum = "54321", CorpName = "Kodlama.io", TaxNum = "123567890" };

            Customer customer3 = new IndivCustomer();
            Customer customer4 = new CorpCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer2);

        }
    }
}
