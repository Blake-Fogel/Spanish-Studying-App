using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spanish_Studying_App.Models
{
    public class Contact_Information
    {
        public Contact_Information(string personalPhone = "", string businessPhone = "", string address = "", string email = "") 
        {
            personalPhoneNumber = personalPhone;
            businessPhoneNumber = businessPhone;
            this.address = address;
            this.email = email;
        }
        public int Id { get; set; }
        public string personalPhoneNumber {  get; set; }
        public string businessPhoneNumber { get; set; }
        public string address { get; set; }
        public string email { get; set; }
    }
}
