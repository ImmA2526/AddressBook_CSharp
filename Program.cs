using System;
using System.Collections.Generic;
using System.Linq;
namespace Address
{
    class Program
    {
       List<PersonalDetail> list ;
        public Program()
        {
            list = new List<PersonalDetail>();
        }

     
        public void EditContact(string FirstName)
        {
            int size = list.Count;
            int check = 0;
            foreach (PersonalDetail Contact in list)
            {
                if (FirstName.Equals(Contact.FirstName))
                {
                    Console.Write(" Enter Firstname: ");
                    string Firstname = Console.ReadLine();
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
                    AddContacts(FirstName, LastName, State, Address, Pincode, MobileNumber);
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
        public void DeleteContact(string FirstName)
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
        public  void Display()
        {
            Console.WriteLine("Details Are...");
            foreach (var value in list)
            {
                PersonalDetail Detail = value;
                Detail.Display();
            }
        }
        public  bool DupFirstName(string First_Name)
        {
            bool Dup = false;
            foreach (PersonalDetail Name in list)
            {
                if (Name.FirstName.Equals(First_Name))
                {
                    Dup = true;
                    Console.WriteLine($"The Name {First_Name} is alredy  Present....");
                    break;
                }
            }
            return Dup;
        }
        public  void SearchContact_City(string City)
        {
            foreach (PersonalDetail Contact in list.FindAll(x=>x.Address.Equals(City)).ToList())
            {
                if (Contact.Address.Equals(City))
                {
                    Contact.Display();
                }
                else
                {
                    Console.WriteLine(City+ "Not Present...");
                    break;
                }
            }
        }
        public void SearchContact_State(string State)
        {
            foreach (PersonalDetail Contact in list.FindAll(x => x.State.Equals(State)).ToList())
            {
                if (Contact.State.Equals(State))
                {
                    Contact.Display();
                }
                else
                {
                    Console.WriteLine(State + "Not Found..");
                }
            }

        }

        public void AddContacts(string FirstName , string LastName, string State, string Address , int Pincode, int MobileNumber)
        {
            bool duplicate = Equals(FirstName);
            if (duplicate)
            {
                Console.WriteLine($"Duplicate Contact not allowed '{0}' is already in address book", FirstName);
            }
            else
            {
                PersonalDetail user = new PersonalDetail(FirstName ,LastName,State,Address ,Pincode, MobileNumber);
                list.Add(user);
            }
        }

        public bool Equals(string first_name)
        {
            if (list.Any(e => e.FirstName == first_name))
                return true;
            else
                return false;
        }

    }
}

