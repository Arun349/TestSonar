namespace Ef_Vehiclemanagement{

    class Update{
     public static void UpdateData()
{
    using (var context = new VehicleContext())
    {
       
        //   Console.WriteLine("Current Books:");
        //   PrintData(); 

       
        Console.Write("Enter your vehicle id :");
        int Vid = Convert.ToInt32(Console.ReadLine());
         
        var VehicleToUpdate = context.Vehicledetails.FirstOrDefault(b => b.Vehicle_Id == Vid);
          
         if (VehicleToUpdate != null)
        {
            Console.WriteLine("Updating  values into the tables: ");
            Console.WriteLine("What you want to update");
            Console.WriteLine(" 1.Vehicle type \n 2.Vechile name\n 3.Vehicle number\n 4.Owner name");
          int updatechoice = Convert.ToInt32(Console.ReadLine());
           string? updatedata=null;
           switch(updatechoice)
        {
            case 1:
                updatedata = "Vehicle type";
            Console.WriteLine($"Current type: {VehicleToUpdate.Vehicle_Type}");
             Console.Write("Enter the vehicle type : ");
            string? newname = Console.ReadLine();
            VehicleToUpdate.Vehicle_Type = newname;
               break;
            case 2:
                updatedata = "Vehicle name";
            Console.WriteLine($"Current vehicle name: {VehicleToUpdate.Vehicle_Name}");
             Console.Write("Enter the new vehicle name: ");
            string? newDomain= Console.ReadLine();
            VehicleToUpdate.Vehicle_Name = newDomain;
            break;
            case 3:
                updatedata = "Vehicle number";
            Console.WriteLine($"Current vehicle number: {VehicleToUpdate.Vehicle_Number}");
            Console.Write("Enter the new vehicle number: ");
            string? newlocation = Console.ReadLine();
            VehicleToUpdate.Vehicle_Number = newlocation;
            break;
            case 4:
                updatedata = "Owner name";
            Console.WriteLine($"Current owner name: {VehicleToUpdate.Owner_Name}");
            Console.Write("Enter the new owner number: ");
            string? newowner = Console.ReadLine();
            VehicleToUpdate.Owner_Name = newowner;
            break;
            
           
}
 context.SaveChanges();
        }
        
        else
        {
            Console.WriteLine($"Book with the Vehicle Id:{Vid} is not found.");
        }
    }
}

}
}