using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts;
            contacts = GetContacts();

            foreach(Contact c in contacts)
            {
                Console.WriteLine("Name: {0}", c.Name);
            }

            Console.Read();
        }

        static List<Contact> GetContacts()
        {
            //var contacts = new List<Contact>
            List<Contact> contacts = new List<Contact>
            {
                new Contact{Name="Ana", Number="+351999999999", Email="ana@email.com"},
                new Contact{Name="Joao", Number="+351911111111", Email="joao@email.com"}
            };
            return contacts;
        }
    }
}
