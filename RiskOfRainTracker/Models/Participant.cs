using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class Participant
    {
        [Key]
        public int ParticipantID { get; set; }
        public string ParticipantName { get; set; }
        public virtual int? ParticipantsDeathEnemy { get; set; }
        public IEnumerable<int> ParticipantTotalDeaths { get; set; }
        public IEnumerable<int> ParticipantTotalKills { get; set; }
        [Required]
        public IEnumerable<int> UItemIds { get; set; }
        public int ParticipantCharacterId { get; set; }
    }
}
