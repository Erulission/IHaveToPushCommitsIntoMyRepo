using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            double myDouble;
            string myString;            
            Boolean myBoolShit;

            Console.WriteLine("Witaj w moim programie! \n Na początek podaj zmienną typu int! Tylko bez szeleństw!\n");
            myInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok, teraz rzuć coś zmiennoprzecinkowego..");
            myDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dobrze! Czas na łańcuch znaków.");
            myString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("No i w końcu typ boolean (zwany boolshitem :P)");
            myBoolShit = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nA oto wartości, które podałeś: \n{0} - int \t{1} - double\n{2} - string\t{3} - boolean", myInteger, myDouble, myString, myBoolShit);
            Console.ReadKey();
        }
    }
}
