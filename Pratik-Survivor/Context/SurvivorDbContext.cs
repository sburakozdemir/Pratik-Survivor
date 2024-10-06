using Microsoft.EntityFrameworkCore;
using Pratik_Survivor.Entities;

namespace Pratik_Survivor.Context
{
    public class SurvivorDbContext:DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options):base(options)
        {
            
        }

        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
        public DbSet<CompetitorsEntity> Competitors => Set<CompetitorsEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            // Category data seeding
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { Id = 1, Name = "Ünlüler", IsDeleted = false },
                new CategoryEntity { Id = 2, Name = "Gönüllüler", IsDeleted = false }
            );

            // Competitors data seeding
            modelBuilder.Entity<CompetitorsEntity>().HasData(
                new CompetitorsEntity { Id = 1, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1, IsDeleted = false },
                new CompetitorsEntity { Id = 2, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1, IsDeleted = false },
                new CompetitorsEntity { Id = 3, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1, IsDeleted = false },
                new CompetitorsEntity { Id = 4, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1, IsDeleted = false },
                new CompetitorsEntity { Id = 5, FirstName = "Özge", LastName = "Açık", CategoryId = 1, IsDeleted = false },
                new CompetitorsEntity { Id = 6, FirstName = "Kıvanç", LastName = "Tatlıtuğ", CategoryId = 1, IsDeleted = false },
                new CompetitorsEntity { Id = 7, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2, IsDeleted = false },
                new CompetitorsEntity { Id = 8, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2, IsDeleted = false },
                new CompetitorsEntity { Id = 9, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2, IsDeleted = false },
                new CompetitorsEntity { Id = 10, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2, IsDeleted = false }
            );
        }
    }
}
