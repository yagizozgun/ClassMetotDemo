using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.SurName + " " + "isimli müşteri eklendi.");
        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("--------Müşteri Bilgileri-------");
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.SurName);
            Console.WriteLine(customer.TcNo);
            Console.WriteLine(customer.Id);
            Console.WriteLine("--------------------------------");


        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.SurName + " " + "isimli müşteri silindi.");
        }
    }
}
