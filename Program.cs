using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Dept = 252;
            customer1.Id = 172634;
            customer1.Name = "MAZLUM BAYAZIT";
            customer1.CreditName = "IHTIYAÇ KREDISI";
            customer1.Time = 60;

            Customers customer2 = new Customers();
            customer2.Dept = 0;
            customer2.Id = 1566663;
            customer2.Name = "HASAN HUSEYIN YANARGOZ";
            customer2.CreditName = "OGRENIM  KREDISI";
            customer2.Time = 30;

            Customers customer3 = new Customers();
            customer3.Dept = 350;
            customer3.Id = 1726;
            customer3.Name = "YUSUF ERSIN";
            customer3.CreditName = "DOST KREDISI";
            customer3.Time = 60;

            CustomerManager custommanager = new CustomerManager();
            custommanager.Add(customer1);
            custommanager.Add(customer2);
            custommanager.Add(customer3);
        }
    }
}
