namespace CIDM3312FinalProject1.Models
{
    public class Game
    {
        public int GameId {get;set;}
        public string GameName {get;set;} = string.Empty;
        public string GameGenre {get;set;} = string.Empty;
        public decimal GamePrice {get;set;}

        public List<Availability> Availabilities {get; set;} = new List<Availability>();
    }
}