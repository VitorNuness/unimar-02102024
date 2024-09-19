using Hotel.app.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Database;

public partial class HotelDbContext : DbContext
{
    public DbSet<Guest> Guests { get; set; }

    public DbSet<Reserve> Reserves { get; set; }

    public DbSet<Room> Rooms { get; set; }



    public HotelDbContext()
    {
    }

    public HotelDbContext(DbContextOptions<HotelDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
