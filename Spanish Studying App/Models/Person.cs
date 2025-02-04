using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spanish_Studying_App.Models
{
    public class Person
    {
        public Person(string firstName = "", string secondName = "")
        {
            this.firstName = firstName;
            this.secondName = secondName;
            contact = new Contact_Information();
        }
        public int Id { get; set; }
        public Contact_Information contact { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
    }
}
