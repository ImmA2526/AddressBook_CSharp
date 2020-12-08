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
            while (true)
            {
                Console.WriteLine("Enter Your Choice to Proceed...\n1.AddContact \n2.DisplayDetail \n3.Edit Detail \n4.Exit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        AddContact();
                        Console.WriteLine("Detail Added Succesfully...");
                        break;
                    case 2:
                        Display();
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Please Enter First Name to Edit :");
                        string Edit = Console.ReadLine();
                        EditContact(Edit);
                        break;
                    default:
                        Console.WriteLine("........Thank You....");
                        Environment.Exit(0);
                        break;
                }
            }
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
            Console.Clear();
            Person.Display();
        }
        public  static void EditContact(string FirstName)
        {
            int size = list.Count;
            int check = 0;
            foreach (PersonalDetail Contact in list)
            {
               
               if (FirstName.Equals(Contact.FirstName))
                {
                    AddContact();
                    Console.WriteLine("Contact Update Succesfully...");
                    list.Remove(Contact);
                    break;
                }
                else if (size == check)
                {
                    Console.WriteLine(" Not Found in AddressBook...");
                    break;
                }
            }
        }
        public static void Display()
        {
            Console.WriteLine("Details Are...");
            foreach (var value in list)
            {
                PersonalDetail Detail = value;
                Detail.Display();
            }
        }
    }
}
