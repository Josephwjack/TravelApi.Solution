using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "Description must be less than 300 characters")]
        public string Description { get; set; }
        // public int Age { get; set; }
    }
}