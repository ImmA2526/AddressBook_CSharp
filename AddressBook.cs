using System;
using System.Collections.Generic;

namespace Address
{
    class AddressBook
    {
        public static Dictionary<string,Program> Dict = new Dictionary<string, Program>();
        
        static void Main(string[] args)
        {
            while (true)
            {
                Program Add = new Program();
                Console.WriteLine("************Welcome to AddressBook**********");
                Console.WriteLine("1.Create AddressBook\n2.Open AddressBook\n3.Delete AddressBook\n4.Exit \nEnter Your Choice to Proceed...  ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Write("Enter Address Book Name: ");
                        string Bookname = Console.ReadLine();
                        bool Check = DuplicateName(Bookname);
                        if (Check)
                        {
                            Console.WriteLine("Enter BookName Again: ");
                            Bookname = Console.ReadLine();
                        }
                        Dict.Add(Bookname,Add);
                        Console.WriteLine("...Address Book Created...");
                        break;
                    case 2:
                        Console.Write("Enter Address Book Name to Open : ");
                        string AddBookname = Console.ReadLine();
                        foreach (var OpenBook in Dict)
                        {
                            if (Dict.ContainsKey(AddBookname))
                            {
                                Console.WriteLine("You Are In : " + AddBookname);
                                //Add.MainMethod() REMOVE;
                                MainMethod(AddBookname);    
                            }
                            else
                            {
                                Console.WriteLine("Book NAme Not Present...");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Enter Book Name to Delete: ");
                        string DeleteBook = Console.ReadLine();
                        foreach (var DeleteBok in Dict)
                        {
                            if (Dict.ContainsKey(DeleteBook))
                            {
                                Console.WriteLine("Book Deleted : " + DeleteBook);
                            }
                            else
                            {
                                Console.Write("Book Bot Present ");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("........Thank You........");
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public static bool DuplicateName(string BookName)
        {
            bool Check = false;
            foreach (var Address in Dict)
            {
                if (Dict.ContainsKey(BookName))
                {
                    Check = true;
                    Console.WriteLine($"AddressBook {BookName}  Alrdy Present Enter Diffrnet Name");
                    break;
                }
            }
            return Check;
        }
        public static void MainMethod(string Bookname)
        { 
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.AddContact \n2.DisplayDetail \n3.Edit Detail \n4.Delete Contact\n5.SearchContact\n6.Search Person By City or State\n7.CountPerson\n8.Exit \nEnter Your Choice to Proceed...  ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        AddContact(Dict[Bookname]);
                        Console.WriteLine("Detail Added Succesfully...");
                        break;
                    case 2:
                        Dict[Bookname].Display();
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.Write("Please Enter First Name to Edit :");
                        string Edit = Console.ReadLine();
                        Dict[Bookname].EditContact(Edit);
                        break;
                    case 4:
                        Console.Write("Please Enter First Name to Delete Contact: ");
                        string Delet = Console.ReadLine();
                        Dict[Bookname].DeleteContact(Delet);
                        break;
                    case 5:
                        Console.Write("Please Enter City To Display Contact associated with it:  ");
                        string City = Console.ReadLine();
                        Dict[Bookname].SearchContact_City(City);
                        break;
                    case 6:
                        Console.Write("Please Enter State to Display Contact associated with it:  ");
                        string State = Console.ReadLine();
                        Dict[Bookname].SearchContact_State(State);
                        break;
                    case 7:
                        bool Repeat = true;
                        do
                        {
                            Console.WriteLine("How you want to see person detail \n1.By City \n2.By State\n3.Exit form View");
                            int Detail = Convert.ToInt32(Console.ReadLine());
                            switch (Detail)
                            {
                                case 1:
                                    Console.Write("Please Enter City To Display Contact associated with it:  ");
                                    string City1 = Console.ReadLine();
                                    int CityCount = 0;
                                    foreach (var cnt in AddressBook.Dict)
                                    {
                                        CityCount++;
                                        Console.WriteLine("City is:  {0} & Count is :{1} ", City1, CityCount);
                                    }
                                    break;
                                case 2:
                                    Console.Write("Please Enter City To Display Contact associated with it:  ");
                                    string State1 = Console.ReadLine();
                                    int StateCount = 0;
                                    foreach (var Count in AddressBook.Dict)
                                    {
                                        StateCount++;
                                        Console.WriteLine("Total State Count is: " + StateCount);
                                    }
                                    break;
                                default:
                                    Console.Write("main");
                                    Repeat = false;
                                    break;
                            }
                        } while (Repeat.Equals(true));
                        break;
                    default:
                        Console.WriteLine("........Thank You........");
                        flag = false;
                        break;
                }
            }
        }
        public static void AddContact(Program program)
        {
            Console.Write(" Enter Firstname: ");
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
            program.AddContacts(FirstName, LastName, State, Address, Pincode, MobileNumber);
        }  
    }
}

