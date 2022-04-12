using System.ComponentModel.DataAnnotations;

namespace Occurrence.DTO
{
    public class CreateDto
    {
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string ContactFirstName { get; set; }
        [Required]
        public string ContactLastName { get; set; }
        [Required]
        public string ContactEmail { get; set; }
        [Required]
        public string IncidentDescription { get; set; }
    }
}
