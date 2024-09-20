using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_Items
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
    }
}
