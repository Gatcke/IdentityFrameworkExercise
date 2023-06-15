using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Learn_Identity_App.Data
{
    //If you want identity you will have to type in the identityDbcontext
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        //Step 1: Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
                
        }

    }
}
