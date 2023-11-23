using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext :DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            

            
        }
        // This will create a Categories table inside the db
        //This is code first approach because we are referring to the written db to form the db on server

        public DbSet<Category> Categories { get; set; }

    }
}
