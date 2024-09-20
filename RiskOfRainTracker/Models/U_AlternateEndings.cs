using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_AlternateEndings
    {
        [Key]
        public int UAlternateEndingID { get; set; }
        public string AlternateEndingName { get; set; }

    }
}
