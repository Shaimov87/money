using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money= new Money(1,170);
            Console.WriteLine(money);

            Money money1 = new Money();
            money1.Penny = 170;
            Console.WriteLine(money1);

            Money money2 = money + money1;
            Console.WriteLine(money2);

            Money money3 = money2 - money1;
            Console.WriteLine(money3);

            Money money4 = money1 * 4;
            Console.WriteLine(money4);

            Money money5 = money1 / 3;
            Console.WriteLine(money5);

            money5++;
            Console.WriteLine(money5);
            money5--;
            Console.WriteLine(money5);

            if (money5 < money4)
                Console.WriteLine("\tmoney5 < money4");
            if (money5 > money4)
                Console.WriteLine("\tmoney5 > money4");

            if (money4 == money5)
                Console.WriteLine("\tmoney4 == money5");
            if (money4 != money5)
                Console.WriteLine("\tmoney4 != money5");
        }
    }
}
