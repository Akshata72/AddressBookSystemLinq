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
    }
}