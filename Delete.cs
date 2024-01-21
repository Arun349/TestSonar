namespace Ef_Vehiclemanagement{
    class Delete{
        public static void RemoveData()
{
    using (var context = new VehicleContext())
    {
    
        // Console.WriteLine("Current Details:");
        // PrintData();

        Console.Write("Enter the Vehicle Id ");
        int  isbnToRemove = Convert.ToInt32(Console.ReadLine());

        
        var vehicleToRemove = context.Vehicledetails.FirstOrDefault(b => b.Vehicle_Id == isbnToRemove);

        if (vehicleToRemove != null)
        {
       
            Console.WriteLine($"Removing Vehicle - id: {vehicleToRemove.Vehicle_Id}, Vehicle name: {vehicleToRemove.Vehicle_Name}");

     
            context.Vehicledetails.Remove(vehicleToRemove);

            
            context.SaveChanges();

            Console.WriteLine("Removal successful!");
        }
        else
        {
            Console.WriteLine($"Vehicle Id is {isbnToRemove} not found.");
        }
    }
}






}  

}