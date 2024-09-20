using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_Difficulties
    {
        [Key]
        public int UDifficultyID { get; set; }
        public string DifficultyName { get; set; }
    }
}
