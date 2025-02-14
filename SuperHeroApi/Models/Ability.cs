using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroApi.Models
{

    public class Ability
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string AbilityName { get; set; }

        public string Description { get; set; }

        [ForeignKey("SuperHero")]
        public int SuperHeroId { get; set; }
        public SuperHero SuperHero { get; set; }
    }
}
   

