using Microsoft.EntityFrameworkCore;

namespace Ef_Vehiclemanagement{

    public class VehicleContext:DbContext{
          public DbSet<Vehicle> Vehicledetails { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=EfVehicle;user=root;password=Password@12345");
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Vehicle>(entity =>
      {
        entity.HasKey(e => e.Vehicle_Id);
        entity.Property(e => e.Vehicle_Type).IsRequired();
        entity.Property(e => e.Vehicle_Name).IsRequired();
        entity.Property(e => e.Vehicle_Number).IsRequired();
        entity.Property(e => e.Owner_Name).IsRequired();

      });

    }


    }
}