using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebToDo.Models;

namespace WebToDo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ToDoModel> Tasks { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("Host=localhost;Database=localserver;Username=postgres;Password=root;Timeout=180;Command Timeout=180;");

    }
}
