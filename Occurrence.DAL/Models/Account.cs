namespace Occurrence.DAL.Models
{
    public class Account
    {
        public string Name { get; set; }
        public List<Contact> Contacts { get; set; }
        public Incident Incident { get; set; }
    }
}
