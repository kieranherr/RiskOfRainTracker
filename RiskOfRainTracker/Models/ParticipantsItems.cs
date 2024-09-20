using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class ParticipantsItems
    {
        [Key]
        public int ParticipantsItemId { get; set; }
        [Required]
        public int ParticipantIds { get; set;}
        public int UItemId { get; set; }
        public int ItemCount { get; set; }
    }
}
