using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    { public void Add(Customers customers)
        { if (customers.Dept > 0) { Console.WriteLine("T.c. no:"+customers.Id);
                Console.WriteLine("Müşteri ismi:"+customers.Name);
                Console.WriteLine("Kredi Adı"+customers.CreditName);
                Console.WriteLine("Kredi Zamanı" +customers.Time);

            } }
    }
}
