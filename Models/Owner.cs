using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Hmmm... You should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }
        public string Address { get; set; }
        
        [DisplayName("Your Hood")]
        public int NeighborhoodId { get; set; }
        public string Phone { get; set; }
        public List<Dog> Dogs { get;set; } = new List<Dog>(); // Initialize the list
    }
}