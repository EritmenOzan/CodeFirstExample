﻿// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

public class VesselTrackingContext : DbContext
{
    public DbSet<Vessel> Vessels { get; set; }
    public DbSet<Owner> Owners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=VesselTrackingDb;Integrated Security=true;Encrypt = False");
    }
    static void Main(string[] args)
    {
        // Programın başlangıç noktası burasıdır
    }
}

public class Vessel
{
    public int VesselId { get; set; }
    public string VesselName { get; set; }
    public int VesselYear { get; set; }
   
}

public class Owner
{
    public int OwnerId { get; set; }
    public string OwnerName { get; set; }
    public ICollection<Vessel> Vessels { get; set; }

}