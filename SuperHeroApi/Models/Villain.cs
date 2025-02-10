using System.ComponentModel.DataAnnotations;

namespace SuperHeroApi.Models
{
    public class Villain
    {
        [Key]
        public int id { get; set; }

        [MaxLength(100)]
        public string VillainName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Place { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Abilities { get; set; } = string.Empty;

        public int Health { get; set; }

        public double Speed { get; set; }

        public int Strength { get; set; }

        [MaxLength(50)]
        public string Role { get; set; } = string.Empty;
    }
}
