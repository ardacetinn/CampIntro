using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args) 
        {
            IndividualCustomer customer1 =  new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Arda";
            customer1.LastName = "Çetin";
            customer1.TcNo = "12345678910";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();


        }
    }
}