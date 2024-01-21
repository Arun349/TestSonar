using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Ef_Vehiclemanagement{
class Program{
    public static void Main(String[] args){
         while (true)
        {
            Console.WriteLine("\t\t\tVehicle Management System");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("1.Insert\t 2.Print\t 3.Update\t 4.Remove\t 5.Exit ");
            Console.Write("Enter your choice: ");
            int  choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                   Create.InsertData();
                    break;
                case 2:
                     Read.PrintData();
                    break;
                case 3:
                    Update.UpdateData();
                    break;
                case 4:
                    Delete.RemoveData();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
}