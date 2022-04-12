namespace Occurrence.DAL.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Account Account { get; set; }
    }
}
