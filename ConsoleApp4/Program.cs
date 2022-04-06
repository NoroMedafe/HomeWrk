using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string auxiliaryVariable;

            firstName = "Алексей";
            Console.WriteLine("Имя:"+firstName) ;
            lastName = "Алексеев";
            Console.WriteLine("Фамилия:" + lastName + "\n");
            auxiliaryVariable = firstName;
            firstName = lastName;
            lastName = auxiliaryVariable;
            Console.WriteLine("Имя:" + firstName);
            Console.WriteLine("Фамилия:" + lastName);
            Console.ReadKey();
        }
    }
}
