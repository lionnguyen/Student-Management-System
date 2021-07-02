using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    abstract class Person
    {


        protected string name;
        protected string bithday;
        protected string address;
        protected string email;



        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            this.name = Name;
        }
        public string getBithday()
        {
            return name;
        }
        public void setBithday(string Bithday)
        {
            this.bithday = Bithday;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string Address)
        {
            this.address = Address;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string Email)
        {

            this.email = Email;

        }

        public virtual void Input()
        {
            do
            {
                Console.Write(" + Enter Name: ");
                setName(Console.ReadLine());
                if (string.IsNullOrEmpty(getName()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(getName()));

            do
            {
                Console.Write(" + Enter Date Of Birth: ");
                setBithday(Console.ReadLine());
                if (string.IsNullOrEmpty(getBithday()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(getBithday()));


            do
            {
                Console.Write(" + Enter Address: ");
                setAddress(Console.ReadLine());
                if (string.IsNullOrEmpty(getAddress()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(getAddress()));

            do
            {
                Console.Write(" + Enter Email: ");
                setEmail(Console.ReadLine());
                if (this.email == null || !this.email.Contains("@") || this.email.Contains(" "))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Error Input! Please Input again. Email must have @ and not have Space! \n");
                    Console.ResetColor();
                }
            } while (this.email == null || !this.email.Contains("@") || this.email.Contains(" "));
         }
        public virtual void ShowInfo()
        {
            Console.WriteLine($" || Name: {getName()}\t| Birthday: {getBithday()}\t| Address: {getAddress()}\t | Email: {getEmail()}\t ");
        }
    }
}