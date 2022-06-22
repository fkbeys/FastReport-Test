using FastTest.Models;
using Microsoft.EntityFrameworkCore;

namespace FastTest.Data
{
    public class ApplicationDbContext :DbContext
    {

         
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        public virtual DbSet<AAAA_PRINT_KREDIT> AAAA_PRINT_KREDIT { get; set; }

    }
}
