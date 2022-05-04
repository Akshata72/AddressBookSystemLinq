using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book linq problem!");
            AddressBook addressBook = new AddressBook();
            int Option = 0;
            do
            {
                Console.WriteLine("Enter your choice: \n1.Insert a new contact \n" +
                "2.Display existing contact" +
                " \n3.Edit existing contact " +
                " \n4.Exit.");
                try
                {
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            addressBook.InsertContactToTable();
                            break;
                        case 2:
                            addressBook.DisplayDetails();
                            break;
                        case 3:
                            addressBook.EditExistingContact();
                            break;
                        default:
                            Console.WriteLine("Please enter the valid number : ");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choose Correct Option...");
                }
            } while (Option != 0);
        }
    }
}