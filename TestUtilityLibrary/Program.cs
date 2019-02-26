using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KenUtilityLibrary;
namespace TestUtilityLibrary
{
    class Program
    { 
        static void Main(string[] args)
        {
            var zip1 = "45140";
            var zip1Valid = Strings.ValidUSZipCode(zip1);
            if(zip1Valid)
            {
                Console.WriteLine($"{zip1} is Valid");
            }
            else
            {
                Console.WriteLine($"{zip1} is Invalid");
            }

            var zip2 = "451401234";
            var zip2Valid = Strings.ValidUSZipCode(zip2);
            if (zip2Valid)
            {
                Console.WriteLine($"{zip2} is Valid");
            }
            else
            {
                Console.WriteLine($"{zip2} is Invalid");
            }

            var zip3 = "45140-1234";
            var zip3Valid = Strings.ValidUSZipCode(zip3);
            if (zip3Valid)
            {
                Console.WriteLine($"{zip3} is Valid");
            }
            else
            {
                Console.WriteLine($"{zip3} is Invalid");
            }

            var phone1 = "322-8888";
            var phone1Valid = Strings.ValidUSPhoneNumber(phone1);
            if(phone1Valid)
            {
                Console.WriteLine($"{phone1} id valid");
            }
            else
            {
                Console.WriteLine($"{phone1} is not valid");
            }
            var phone2 = "513-322-8888";
                 var phone2Valid = Strings.ValidUSPhoneNumber(phone2);
            if (phone1Valid)
            {
                Console.WriteLine($"{phone2} id valid");
            }
            else
            {
                Console.WriteLine($"{phone2} is not valid");
            }

            var result = Strings.EqualIgnoreCase("ABC", "abc");
            if (result)
            {
                Console.WriteLine("EQUAL");
            }
            else
            {
                Console.WriteLine("NOT EQUAL");
            }
            Console.ReadKey();
        }
    }
}
