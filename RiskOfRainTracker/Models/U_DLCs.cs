using System.ComponentModel.DataAnnotations;

namespace RiskOfRainTracker.Models
{
    public class U_DLCs
    {
        [Key]
        public int UDLCId { get; set; }
        public string DLCName { get; set;}
    }
}
