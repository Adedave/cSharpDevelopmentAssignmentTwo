using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCostPlatform
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CompanyInfo.SimpleCalc(9,9));
            Console.Write("Input your username: ");
            
            UserInfo user1 = new UserInfo();
            user1.Username = Console.ReadLine();

            Console.Write("Input your firstname: ");
            user1.FirstName = Console.ReadLine();

            Console.Write("Input your lastname: ");
            user1.LastName = Console.ReadLine();

            Console.Write("Input your email address: ");
            user1.EmailAddress = Console.ReadLine();

            Console.Write("Input your phone number: ");
            user1.PhoneNumber = Console.ReadLine();

            Console.Write("Input your company's name: ");
            CompanyInfo user1CompInfo = new CompanyInfo();
            
            user1CompInfo.CompanyName = Console.ReadLine();

            Console.Write("Input your company's address: ");
            user1CompInfo.CompanyAddress = Console.ReadLine();

            Console.Write("Input your company's phone number: ");
            user1CompInfo.CompanyPhoneNumber = Console.ReadLine();

            Console.WriteLine(user1.Username);
            Console.WriteLine(user1.FirstName);
            Console.WriteLine(user1.LastName);
            Console.WriteLine(user1.EmailAddress);
            Console.WriteLine(user1.PhoneNumber);
            Console.WriteLine(user1CompInfo.CompanyName);
            Console.WriteLine(user1CompInfo.CompanyAddress);
            Console.WriteLine(user1CompInfo.CompanyPhoneNumber);
            
            Console.ReadLine();
        }
    }
}
