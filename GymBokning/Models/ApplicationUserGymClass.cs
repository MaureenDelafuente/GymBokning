namespace GymBokning.Models;

// connection table
public class ApplicationUserGymClass
{
    //foreign keys
    public int ApplicationUserId { get; set; }
    public int GymClassId { get; set; }

    //navigional properties
    public ApplicationUser ApplicationUser { get; set; }
    public GymClass GymClass { get; set; }
}