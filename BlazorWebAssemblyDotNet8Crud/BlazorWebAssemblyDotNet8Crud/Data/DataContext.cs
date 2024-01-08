using BlazorWebAssemblyDotnet8Crud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyDotNet8Crud.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }
        public DbSet<VideoGame> VideoGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGame>().HasData(
                    new VideoGame { Id = 1, Title="Cyberpunk 2077", Publisher="CD Project", ReleaseYear=2020},
                    new VideoGame { Id = 2, Title="Elden Ring", Publisher="From Software", ReleaseYear=2022},
                    new VideoGame { Id = 3, Title="The Legend of Zelda: Ocarina of Time", Publisher="Nintendo", ReleaseYear=1998}
                );
        }
    }
}
