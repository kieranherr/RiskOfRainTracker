using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiskOfRainTracker.Models
{
    public class RunAttributes
    {
        [Key]
        public int RunId { get; set; }
        [Required]
        public string RunParticipantIds { get; set; }
        public int RunUDifficultyId { get; set; }
        public bool ModdedRun { get; set; }
        public string? ModProfileName { get; set; }
        public bool DLCRun { get; set; }
        public string? DLCIds { get; set; }
        public string UArtifactIds { get; set; }
        public int RunLevelEnd { get; set; }
        public DateTime RunDate { get; set; }
        public int RunLengthHours { get; set; }
        public int RunLengthMinutes { get; set;}
        public bool FoughtMithrix { get; set; }
        public bool? BeatMitrhrix { get; set; }
        public bool? AlternateEnding { get; set; }
        public int AlternateEndingId { get; set; }
        public bool? BeatAlternateEnding { get; set; }

    }
}
