using System;
using System.Collections.Generic;
namespace Address
{
    public class PersonalDetail
    {
        public string FirstName;
        public string LastName;
        public string State;
        public string Address;
        public int Pincode;
        public int MobileNumber;
        public PersonalDetail(string FirstName, string LastName,  string State, string Address,int Pincode, int MobileNumber)
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
            Console.WriteLine("\nFirst Name: \t " + FirstName + "\n Last Name: \t " + LastName + "\n State: \t " + State + "\n Address: \t " + Address + "\n PinCode: \t " + Pincode + "\n Mob Number:\t  " + MobileNumber);
        }
    }
}
