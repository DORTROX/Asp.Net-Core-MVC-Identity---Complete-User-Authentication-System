using System.ComponentModel.DataAnnotations;

namespace AuthSystem.Models
{
    public class Contact
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
    public class CardUploads
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public int MyProperty { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Color { get; set; }

        public string Designation { get; set; }

        public string AboutMe { get; set; }

        public Contact ContactInfo { get; set; }
    }   
}
