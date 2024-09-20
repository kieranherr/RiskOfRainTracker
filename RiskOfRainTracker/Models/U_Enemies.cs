using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_Enemies
    {
        [Key]
        public int UEnemyID { get; set; }
        public string EnemyName { get; set; }
        public string EnemyType { get; set;}
    }
}
