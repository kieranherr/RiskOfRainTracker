using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_Characters
    {
        [Key]
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
    }
}
