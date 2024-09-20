using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class ParticipantCharacters
    {
        [Key]
        public int ParticipantCharacterId { get; set; }
        public int ParticipantId { get; set; }
        public int UCharacterId { get; set; }
        public int CharacterLoadoutId { get; set; }
    }
}
