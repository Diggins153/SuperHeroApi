using System.ComponentModel.DataAnnotations;

namespace SuperHeroApi.Models
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string HeroName { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Place { get; set; }

        public string Description { get; set; }

        public int? Health { get; set; }

        public float? Speed { get; set; }

        public int? Strength { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        public ICollection<Ability> Abilities { get; set; }
    }
}