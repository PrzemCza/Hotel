using Microsoft.EntityFrameworkCore;


public static class DbInitializer
{
    public static void Seed(HotelContext context)
    {
        if (context.Rooms.Any())
        {
            return;   // DB has been seeded
        }

        var rooms = new Room[]
        {
            new Room { Name = "Room 101", IsAvailable = true },
            new Room { Name = "Room 102", IsAvailable = true },
            new Room { Name = "Room 103", IsAvailable = true },
            new Room { Name = "Room 104", IsAvailable = true },
            new Room { Name = "Room 105", IsAvailable = true },
            new Room { Name = "Room 201", IsAvailable = true },
            new Room { Name = "Room 202", IsAvailable = true },
            new Room { Name = "Room 203", IsAvailable = true },
            new Room { Name = "Room 204", IsAvailable = true },
            new Room { Name = "Room 205", IsAvailable = true }
        };

        foreach (Room r in rooms)
        {
            context.Rooms.Add(r);
        }
        context.SaveChanges();
    }
}
public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

    public DbSet<Room> Rooms { get; set; }
}
