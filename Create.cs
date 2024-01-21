namespace Ef_Vehiclemanagement{
    class Create{
        public static void InsertData()
    {
      using(var context = new VehicleContext())
      {
        
        context.Database.EnsureCreated();
        Console.WriteLine("Enter Vehicle id:");

        int vid =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the vehicle type:");

        string? vtype = Console.ReadLine();
        Console.WriteLine("Enter the vehicle name:");

        string? vname = Console.ReadLine();
        Console.WriteLine("Enter the vehicle number:");

        string? vno = Console.ReadLine();
        Console.WriteLine("Enter the owner name:");
        
        string? oname= Console.ReadLine();
        context.Vehicledetails.Add(new Vehicle
        {
          Vehicle_Id=vid,
          Vehicle_Type=vtype,
          Vehicle_Name=vname,
          Vehicle_Number=vno,
          Owner_Name=oname
        });
    
        context.SaveChanges();
      }
    }

    }
}