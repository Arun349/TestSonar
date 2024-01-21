using System.Text;

namespace Ef_Vehiclemanagement{
    class Read{
        public static void PrintData()
    {
      
      using (var context = new VehicleContext())
      {
       
        foreach(var Vehicledetails in context.Vehicledetails )
        {
          var data = new StringBuilder();
          data.AppendLine($"Vehicle_Id: {Vehicledetails.Vehicle_Id}");
          data.AppendLine($"Vehicle_type: {Vehicledetails.Vehicle_Type}");
          data.AppendLine($"Vehicle_Name: {Vehicledetails.Vehicle_Name}");
          data.AppendLine($"Vehicle_Number: {Vehicledetails.Vehicle_Number}");
          data.AppendLine($"Owner_Name: {Vehicledetails.Owner_Name}");
          Console.WriteLine(data.ToString());
        }
      }
    }

    }
}