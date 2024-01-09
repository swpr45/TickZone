using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TickZone.Data.Base;

namespace TickZone.Models
{
    public class Producer:IEntityBase
    {
        //Adding properties for Producer table same as Actor
        /*Remember we notice that both actor and producer as
          same properties instead of writing again and again 
         we use one base class, write properties in it and 
        we inherit that properties from that base class to actor and 
        producer class,but in current scenario properties are not too many so
        we opt to write then directly without using base class*/


        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Profile Picture is required")]
        [DisplayName("Profile Picture")]
        public string ProfilePicture { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Full Name is required")]

        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [DisplayName("Biography")]
        public string Bio { get; set; }
        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
