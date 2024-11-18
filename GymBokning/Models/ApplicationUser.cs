using Microsoft.AspNetCore.Identity;

namespace GymBokning.Models;

public class ApplicationUser : IdentityUser
{
    //navigation property
    public ICollection<ApplicationUserGymClass> GymClasses { get; set; } = new List<ApplicationUserGymClass>();
}