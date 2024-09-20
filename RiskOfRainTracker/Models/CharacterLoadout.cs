using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class CharacterLoadout
    {
        [Key]
        public int CharacterLoadoutId { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set;}
        public string UtilitySkill { get; set; }
        public string SpecialSkill { get; set; }
    }
}
