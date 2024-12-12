using System.ComponentModel.DataAnnotations;

namespace TheFinal_jacalva.Models;

public class Game
{
    public int GameID {get; set;} //primary key

    [Display(Name="Game Title")]   
    public string GameTitle {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;

    [Display(Name="Number of Copies Sold")]   
    public double CopiesSold {get; set;}
    public double YearReleased {get; set;}
    
    [Range(1, 5)]
    public int Rating {get; set;}

    [Display(Name = "Game Cover")]
    public string ImageURL {get; set;} = string.Empty;

    // This property is optional (?) because Studios can exist without having games. 
    public List<StudioGame>? StudioGames {get; set;} = default!; // Navigation property. A studio can create many games.

}

public class StudioGame
{
    public int GameID {get; set;} // Composite Primary Key, Foreign Key 1
    public int StudioID {get; set;} // Composite Primary Key, Foreign Key 2
    public Studio Studio {get; set;} = default!; // Navigation Property
    public Game Game {get; set;} = default!; // Navigation Property
}