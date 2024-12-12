using System.ComponentModel.DataAnnotations;
using TheFinal_jacalva.Models;

namespace TheFinal_jacalva.Models;

public class Studio
{

    public int StudioID {get; set;} // Primary Key

    [Display(Name="Studio Name")]    
    public string StudioName {get; set;} = string.Empty;

    [Display(Name="Acquisiton Year")] 
    public int acquisitionyear {get; set;}

    // This property is optional (?)
    [Display(Name = "Studio Games")]
    public List<StudioGame>? StudioGames {get; set;} = default!; // Navigation property.


}