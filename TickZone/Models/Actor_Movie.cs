using System.ComponentModel.DataAnnotations;

namespace TickZone.Models
{
    public class Actor_Movie
    {
        [Key]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
