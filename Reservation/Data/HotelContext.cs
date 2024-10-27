using Microsoft.EntityFrameworkCore;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

    public DbSet<Room> Rooms { get; set; }
}