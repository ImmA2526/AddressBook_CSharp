using System;
using System.Collections.Generic;

namespace Address
{
    class Program
    {
        public static LinkedList<PersonalDetail> list = new LinkedList<PersonalDetail>();
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome to AddressBook**********");
            AddContact();

        }
        public static void AddContact()
        {
            Console.Write("Enter Firstname: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter LastName: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter State: ");
            string State = Console.ReadLine();
            Console.Write("Enter Address : ");
            string Address = Console.ReadLine();
            Console.Write("Enter Pincode: ");
            int Pincode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mobile Number: ");
            int MobileNumber = Convert.ToInt32(Console.ReadLine());
            PersonalDetail Person = new PersonalDetail(FirstName,LastName,State,Address,Pincode,MobileNumber);
            list.AddFirst(Person);
            Person.Display();
        }
    }
}
