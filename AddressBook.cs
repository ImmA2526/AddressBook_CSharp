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
                Console.WriteLine("1. Create AddressBook\n2. Open AddressBook\n3. Delete AddressBook\n4. Exit \nEnter Your Choice to Proceed...  ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                int size=Dict.Count;
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
                        Program Add = new Program();
                        Dict.Add(Bookname,Add);
                        Console.WriteLine("...Address Book Created...");
                        break;
                    case 2:
                        Console.Write("Enter Address Book Name to Enter... ");
                        string AddBookname = Console.ReadLine();
                        //int ch=0;
                        foreach (var OpenBook in Dict)
                        {
                            if (Dict.ContainsKey(AddBookname))
                            {
                                Console.WriteLine("Opened Book" + AddBookname);
                                Program.MainMethod();
                            }

                            else
                            {
                                Console.WriteLine("Book NAme Not Present...");
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Enter Name to Delete ");
                        string DeleteBook = Console.ReadLine();
                        foreach (var DeleteBok in Dict)
                        {
                            if (Dict.ContainsKey(DeleteBook))
                            {
                                Console.WriteLine("Book Deleted" + DeleteBook);
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
    }
}

