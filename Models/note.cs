using Microsoft.AspNetCore.Identity;

namespace reactnet.Models;

public class Note : IdentityUser
{
    public int id { get; set;}
    public int Title { get; set;}
    public int Description { get; set;}
    

}
