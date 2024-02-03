namespace Book.Data;

using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Entities.Author> Authors { get; set; } = null!;
    public DbSet<Entities.Book> Books { get; set; } = null!;
    public DbSet<Entities.Publisher> Publishers { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("LibraryDatabase");
        optionsBuilder.UseSqlServer(connectionString);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entities.Author>().HasKey(b => b.AuthorId);
        modelBuilder.Entity<Entities.Book>().HasKey(b => b.BookId);
        modelBuilder.Entity<Entities.Publisher>().HasKey(b => b.PublisherId);
    }
}
