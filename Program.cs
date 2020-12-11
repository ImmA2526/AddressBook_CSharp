using System;
using System.Collections.Generic;

namespace Address
{
    class Program
    {
        public static LinkedList<PersonalDetail> list ;
        public Program()
        {
            list = new LinkedList<PersonalDetail>();
        }

     public static void MainMethod()
        {
            bool flag = true;
            Console.WriteLine("************Welcome to AddressBook**********");  
            while (flag)
            {
                Console.WriteLine("1.AddContact \n2.DisplayDetail \n3.Edit Detail \n4.Delete Contact\n5.Exit \nEnter Your Choice to Proceed...  ");
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
                        Console.Write("Please Enter First Name to Edit :");
                        string Edit = Console.ReadLine();
                        EditContact(Edit);
                        break;
                    case 4:
                        Console.Write("Please Enter First Name to Delete Contact: ");
                        string Delet = Console.ReadLine();
                        DeleteContact(Delet);
                        break;
                    default:
                        Console.WriteLine("........Thank You........");
                        flag = false;
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
        public static void EditContact(string FirstName)
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
        public static void DeleteContact(string FirstName)
        {
            foreach (PersonalDetail Contact in list)
            {
                if (FirstName.Equals(Contact.FirstName))
                {
                    list.Remove(Contact);
                    Console.WriteLine("Contact Delete Succesfully...");
                    break;
                }
                else
                {
                    Console.Write("Contact Not Found...");
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

