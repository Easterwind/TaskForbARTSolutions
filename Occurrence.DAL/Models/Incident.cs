namespace Occurrence.DAL.Models
{
    public class Incident
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
