// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class VesselTrackingContext : DbContext
{
    public DbSet<Vessel> Vessels { get; set; }
    public DbSet<Owner> Owners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=VesselTrackingDb;Integrated Security=true;Encrypt = False");
    }
}

public class Vessel
{
    public int VesselId { get; set; }
    public string VesselName { get; set; }
    public int VesselYear { get; set;}  
    public Owner Owner { get; set; }
}

public class Owner
{
    public int OwnerId { get; set; }
    public string OwnerName { get; set; }
    public Vessel Vessel { get; set; }
}