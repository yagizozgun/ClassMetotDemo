using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Yiğit";
            customer1.SurName = "Şimsek";
            customer1.TcNo = "46425895356";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Eylül";
            customer2.SurName = "Çartı";
            customer2.TcNo = "75424680521";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.ListCustomer(customer1);
            customerManager.DeleteCustomer(customer1);
        }
    }
}
