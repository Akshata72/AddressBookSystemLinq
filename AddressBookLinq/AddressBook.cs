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
            table.Rows.Add("Ajinkya", "Shinde", "Apegaon", "Ambejogai", "Maharashtra", 431517, 8806184089, "shindeaj@gmail.com");
            table.Rows.Add("Sachin", "Dhage", "Dhanora", "Latur", "Maharashtra", 433546, 8806184087, "dhage@gmail.com");
            table.Rows.Add("Supriya", "Kadam", "Tadola", "Solapur", "Maharashtra", 411016, 8806184085, "kadamsupriy@gmail.com");
            table.Rows.Add("Ketaki", "Kulkarni", "Parali", "Beed", "Maharashtra", 400154, 8806184082, "kulkarni@gmail.com");
            table.Rows.Add("Pratiksha", "Tat", "Kothrude", "Pune", "Maharashtra", 4110343, 9702420754, "pratiksha@gmail.com");

        }
        public void DisplayDetails()
        {
            foreach (var table in table.AsEnumerable())
            {
                // Get all field by column index.
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber:-" + table.Field<string>("PhoneNumber"));
                Console.WriteLine("Email:-" + table.Field<string>("Email"));
            }
        }
        //UC4- Edit contact from Data Table
        public void EditExistingContact()
        {
            try
            {
                string editName = "Pratiksha";
                var updateData = table.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(editName)).FirstOrDefault();
                if (updateData != null)
                {
                    updateData.SetField("PhoneNumber", "895478520");
                    updateData.SetField("City", "Pune");
                    Console.WriteLine("\n PhoneNumber and ity of {0} updated successfully!", editName);
                    DisplayDetails();
                }
                else
                {
                    Console.WriteLine("There is no such record in the Address Book!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC5- Delete Data Table
        public void DeleteContact(string firstName)
        {
            try
            {
                var rowDelete = table.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals(firstName)).FirstOrDefault();
                if (rowDelete != null)
                {
                    rowDelete.Delete();
                    Console.WriteLine("\nContact with name '{0}' deleted successfully!", firstName);
                    DisplayDetails();
                }
                else
                {
                    Console.WriteLine("There is no such data");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //UC6-Reterive Data By City And State
        public void retrievePersonByUsingCity(List<Contact> contacts)
        {
            Console.WriteLine("Enter a city");
            string city = Console.ReadLine();
            var RecordedData = (from contact in contacts
                                where contact.City == city
                                select contact);
            foreach (var list in RecordedData)
            {
                Console.WriteLine("\nFirstName = " + list.FirstName + "\nLastName = " + list.LastName + "\nAddress = " + list.Address + "\nCity = " + list.City + "\nState = " + list.State + "\nZipCode = " + list.ZipCode + "\nPhoneNumber = " + list.PhoneNumber + "\nEmail = " + list.Email);
            }
        }
        public void retrievePersonByUsingState(List<Contact> contacts)
        {
            Console.WriteLine("Enter a State");
            string state = Console.ReadLine();
            var RecordedData = (from contact in contacts
                                where contact.State == state
                                select contact);
            foreach (var list in RecordedData)
            {
                Console.WriteLine("\nFirstName = " + list.FirstName + "\nLastName = " + list.LastName + "\nAddress = " + list.Address + "\nCity = " + list.City + "\nState = " + list.State + "\nZipCode = " + list.ZipCode + "\nPhoneNumber = " + list.PhoneNumber + "\nEmail = " + list.Email);
            }
        }

        //UC7- sort Contact Alphabetically For Given City
        public void sortContactAlphabeticallyForGivenCity(List<Contact> contacts)
        {
            Console.WriteLine("Enter City");
            string city = Console.ReadLine(); 
            var records = (from contact in contacts
                           where (contact.City == city)
                              orderby contact.FirstName , contact.LastName
                descending select contact);
            foreach (var list in records)
            {
                Console.WriteLine("\nFirstName = " + list.FirstName + "\nLastName = " + list.LastName + "\nAddress = " + list.Address + "\nCity = " + list.City + "\nState = " + list.State + "\nZipCode = " + list.ZipCode + "\nPhoneNumber = " + list.PhoneNumber + "\nEmail = " + list.Email);
            }
        }
    }
}