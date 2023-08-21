using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genric
{
    class Program
    {

        static void Main(string[] args)
        {
            Vehicle Vehicle = new Vehicle()
            {
                Id = 1,
                VehicleNoPlate = "MH34 DS 0001",
                OwnerName = "shubham",
                ContactNo = "8668582779"
            };
            
            ParkingSpace ParkingSpace = new ParkingSpace()
            {
                NOOFSPACE = 400
            };
            ParkingTicket ParkingTicket = new ParkingTicket()
            {
                VehicleID = 1,
                SpaceID = 300,
                EntryDateTime = DateTime.Now,
                ExitDateTime = DateTime.Now
            };


            TotalAmount TotalAmount = new TotalAmount()
            {
               TicketID = 500,
               VehicleName = "audi",
               Amount = 100,
               ParkingDuration = 120

            };

        
         Console.WriteLine(Vehicle.Id +" "+ Vehicle.VehicleNoPlate + " " +Vehicle.OwnerName + " " + Vehicle.ContactNo);
         Console.WriteLine(ParkingSpace.NOOFSPACE);
         Console.WriteLine(ParkingTicket.VehicleID + " " + ParkingTicket.SpaceID + " " + ParkingTicket.EntryDateTime + " " + ParkingTicket.ExitDateTime);
         Console.WriteLine(TotalAmount.TicketID + " " + TotalAmount.VehicleName + " " + TotalAmount.Amount + " " + TotalAmount.ParkingDuration);
         Console.ReadKey();
        }

        public class ticket<T, A>
        {
            public T Id { get; set; }
            public A CreatedOn { get; set; }
        }

        public class Vehicle : ticket<int, DateTime>
        {
            public string VehicleNoPlate { get; set; }
            public string OwnerName { get; set; }
            public string ContactNo { get; set; }
        }

        public class ParkingSpace : ticket<int, DateTime>
        {
            public int NOOFSPACE { get; set; }
        }

        public class ParkingTicket : ticket<int, DateTime>
        {
            public int VehicleID { get; set; }
            public int SpaceID { get; set; }
            public DateTime EntryDateTime { get; set; }
            public DateTime ExitDateTime { get; set; }
        }

        public class TotalAmount : ticket<int, DateTime>
        {
            public int TicketID { get; set; }
            public string VehicleName { get; set; }
            public int Amount { get; set; }
            public int ParkingDuration { get; set; }
        }
     }  
}






