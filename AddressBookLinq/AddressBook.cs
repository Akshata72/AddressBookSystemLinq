using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Linq
{
    class AddressBook
    {
        DataTable table = new DataTable("AddressBook");
        public AddressBook()
        {
            // Here store Type as a field
            //column Represents all table columns
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
        }
        // UC3 Method to insert data into the address book contact table
        public void InsertContactToTable()
        {
            Console.Write("\nEnter the first name of the contact : ");
            string firstName = Console.ReadLine();
            Console.Write("\nEnter the last name of the contact : ");
            string lastName = Console.ReadLine();
            Console.Write("\nEnter the address of the contact : ");
            string address = Console.ReadLine();
            Console.Write("\nEnter the city of the contact : ");
            string city = Console.ReadLine();
            Console.Write("\nEnter the state of the contact : ");
            string state = Console.ReadLine();
            Console.Write("\nEnter the zip code of the contact : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the phone number of the contact : ");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.Write("\nEnter the email id of the contact : ");
            string email = Console.ReadLine();

            table.Rows.Add(firstName, lastName, address, city, state, zip, phone, email);

            Console.WriteLine("Contact details added successfully!");
        }
    }
}