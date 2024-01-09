using System.ComponentModel.DataAnnotations;
using TickZone.Data.Base;

namespace TickZone.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Cinema logo")]
        public string Logo { get; set; }

        [Display(Name ="Cinema Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
