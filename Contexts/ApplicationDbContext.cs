using Microsoft.EntityFrameworkCore;
using ContactApplication.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ContactApplication.Context
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ContactApplicationDB;Username=postgres;Password=Maycg1805$");
       }
       public void ConfigureServices(IServiceCollection services)
{
        services.AddDbContext<ApplicationDbContext>(options => {
        options.UseNpgsql("Host=localhost;Port=5432;Database=ContactApplicationDB;Username=postgres;Password=Maycg1805$");
    });
}

        public virtual DbSet<Register> Register { get; set; }

        public virtual DbSet<Login> Login { get; set; }

        public virtual DbSet<Contact> Contact { get; set; }

        public virtual DbSet<CallLogs> CallLogs { get; set; }

    }
}