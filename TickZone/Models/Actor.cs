using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TickZone.Data.Base;

namespace TickZone.Models
{
    public class Actor:IEntityBase
    {
        // Adding properties for Actor table
        [Key]
        public int Id { get; set; }


        [Display(Name = "Profile")]
        [Required]
        public string  ProfilePicture { get; set; }

        [Display(Name = "Name")]
        [Required]
        
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required]
        public string  Bio { get; set; }

        //RelationShips

        
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
