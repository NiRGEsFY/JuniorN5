using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorN5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ann";
            string secondName = "Deny";
            Console.WriteLine(firstName + "\t" + secondName);
            string buffer = firstName;
            firstName = secondName;
            secondName = buffer;
            Console.WriteLine(firstName + "\t" + secondName);
            Console.ReadLine();
        }
    }
}
