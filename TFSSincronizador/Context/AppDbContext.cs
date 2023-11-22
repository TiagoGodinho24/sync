using Microsoft.EntityFrameworkCore;
using TFSSincronizador.Models;

namespace TFSSincronizador.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<MappingStatus> MappingStatuses { get; set; }
        public DbSet<MappingType> MappingTypes  { get; set; }   
        public DbSet<MappingField> MappingFields   { get; set; }
        public DbSet<JiraFields> JiraFields { get; set; }
        public DbSet<JiraStatus> JiraStatus { get; set; }
        public DbSet<JiraType> JiraTypes { get; set; }
        public DbSet<TFSFields> TFSFields { get; set; } 
        public DbSet<TFSStatus> TFSStatus { get; set; }
        public DbSet<TFSType> TFSTypes { get; set; }    
        public DbSet<ProfileConfiguration> ProfileConfig { get; set; }


    }
}
