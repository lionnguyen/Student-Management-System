using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class Student : Person
    {
        private string stID;
        protected string stBatch;
        public string _stID { get => stID; set => stID = value; }

        public override void Input()
        {
            do
            {
                Console.Write(" + Enter Student ID: ");
                stID = (Console.ReadLine());
                if (string.IsNullOrEmpty(_stID))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t => Empty Input! Please INPUT again. \n");
                    Console.ResetColor();
                }
            } while (string.IsNullOrEmpty(_stID));
            base.Input();
            Console.Write(" + Enter Class:");
            stBatch = (Console.ReadLine()); 
        }

        public override void ShowInfo()
        {
            Console.Write($"\n + Student ID\t: {stID} ");
            base.ShowInfo();
            Console.Write($"\n + Class: {stBatch} ");
            Console.WriteLine("\n ___________________________________________________________________________________________________________");
        }
    }
}
