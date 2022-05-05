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
            List<Contact> contact = new List<Contact>()
            {
            new Contact() { FirstName = "Ajinkya",LastName = "Shinde", Address = "Apegaon",City = "Ambejogai",State = "Maharashtra", ZipCode = 431517,PhoneNumber = 8806184089,Email = "shindeaj@gmail.com" },
            new Contact() { FirstName = "Sachin",LastName = "Dhage",Address = "Dhanora",City = "Latur",State = "Maharashtra",ZipCode = 433546,PhoneNumber = 8806184087,Email = "dhage@gmail.com" },
            new Contact() { FirstName = "Supriya",LastName = "Kadam",Address = "Tadola",City = "Solapur",State = "Maharashtra",ZipCode = 411016,PhoneNumber = 8806184085,Email = "kadamsupriy@gmail.com" },
            new Contact() { FirstName = "Ketaki",LastName = "Kulkarni",Address = "Parali",City = "Beed",State = "Maharashtra",ZipCode = 400154,PhoneNumber = 8806184082,Email = "kulkarni@gmail.com" },
            new Contact() { FirstName = "Pratiksha",LastName = "Tat",Address = "Kothrude",City = "Pune",State = "Maharashtra",ZipCode = 4110343,PhoneNumber = 9702420754,Email = "pratiksha@gmail.com" }
            };
            foreach (var list in contact)
            {
                Console.WriteLine("\nFirstName= " + list.FirstName + "\nLastName= " + list.LastName + "\nAddress= " + list.Address + "\nCity= " + list.City + "\nState= " + list.State + "\nZipCode= " + list.ZipCode + "\nPhoneNumber= " + list.PhoneNumber + "\nEmail= " + list.Email);
            }

            Console.WriteLine("Welcome to Address book linq problem!");
            AddressBook addressBook = new AddressBook();
            int Option = 0;
            do
            {
                Console.WriteLine("\nEnter your choice: \n1.Insert a new contact \n" +
                "2.Display existing contact" +
                " \n3.Edit existing contact " +
                " \n4.Delete existing contact " +
                " \n5.Reterive Data From City" +
                "\n6.Reterive Data From State" +            
                " \n7.Exit.");
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
                        case 4:
                            addressBook.DeleteContact("Sachin");
                            break;
                        case 5:
                         addressBook.retrievePersonByUsingCity(contact);
                            break;
                        case 6:
                            addressBook.retrievePersonByUsingState(contact);
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