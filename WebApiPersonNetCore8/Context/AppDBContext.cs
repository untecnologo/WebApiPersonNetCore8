using Microsoft.EntityFrameworkCore;
using WebApiPersonNetCore8.Models;

namespace WebApiPersonNetCore8.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
