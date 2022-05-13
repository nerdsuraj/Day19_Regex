using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello project");

            UserName username = new UserName();

            Console.WriteLine(username.ValidateUserName("Prakash"));

            Console.WriteLine(username.ValidateLastName("Mahto"));

            Console.WriteLine(username.ValidateEmailId("abc.xyz@bl.co.in"));

            Console.WriteLine(username.ValidatePhoneNum("+91 6200749278"));

            Console.WriteLine(username.ValidatePassword("surajkumar"));

            Console.WriteLine(username.ValidatePassword2("Surajkumar"));

            Console.WriteLine(username.ValidatePassword3("Surajk236umar"));

            Console.WriteLine(username.ValidatePassword4("Surajk236umar@"));



            Console.ReadLine();
        }
    }
}
