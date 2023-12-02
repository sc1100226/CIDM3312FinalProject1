using System.ComponentModel.DataAnnotations;

namespace CIDM3312FinalProject1.Models
{

    public class Availability
    {
        public int AvailabilityId{get; set;}

        [Required]
        public string Available {get; set;} = string.Empty;

        [Display(Name = "Game")]
        [Required]
        public int GameId {get; set;}
        public Game? Game {get; set;}
    }
}