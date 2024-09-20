using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_Artifacts
    {
        [Key]
        public int UArtifactID { get; set; }
        public string ArtifactName { get; set;}
        public string ArtifactDescription { get; set;}
    }
}
