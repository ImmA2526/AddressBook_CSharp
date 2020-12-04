using System;
using System.Collections.Generic;
using System.Text;

namespace Address
{
    class PersonalDetail
    {
        private string FirstName;
        private string LastName;
        private string State;
        private string Address;
        private int Pincode;
        private int MobileNumber;
        public PersonalDetail(string FirstName, string LastName, int Pincode, int MobileNumber, string State, string Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.State = State;
            this.Address = Address;
            this.Pincode = Pincode;
            this.MobileNumber = MobileNumber;
        }

        public void Display()
        {
            Console.WriteLine("\nFirst Name: \t " +FirstName+ "\n Last Name: \t "+ LastName+ "\n State: \t " + State + "\n Address: \t " + Address+"\n PinCode: \t " +Pincode+ "\n Mob Number:\t  "+MobileNumber);
        }

    }
}
