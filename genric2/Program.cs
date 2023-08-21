using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genric2
{
    using System;

    namespace GenericExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                Vehicle<int, DateTime> vehicle = new Vehicle<int, DateTime>()
                {
                    Id = 1,
                    VehicleNoPlate = "MH34 DS 0001",
                    OwnerName = "shubham",
                    ContactNo = "8668582779",
                    CreatedOn = DateTime.Now
                };
                Console.WriteLine(vehicle.CreatedOn);

                ParkingSpace<int, DateTime> parkingSpace = new ParkingSpace<int, DateTime>()
                {
                    NOOFSPACE = 400
                };

                ParkingTicket<int, DateTime> parkingTicket = new ParkingTicket<int, DateTime>()
                {
                    VehicleID = 1,
                    SpaceID = 300,
                    EntryDateTime = new DateTime(2023, 08, 12),
                    ExitDateTime = new DateTime(2023, 08, 13)
                };

                TotalAmount<int, DateTime> totalAmount = new TotalAmount<int, DateTime>()
                {
                    TicketID = 500,
                    VehicleName = "audi",
                    Amount = "100",
                    ParkingDuration = "120"
                    
                };
            }

            public class ticket<T, A>
            {
                public T Id { get; set; }
                public A CreatedOn { get; set; }
            }

            public class Vehicle<T, A> : ticket<T, A>
            {
                public string VehicleNoPlate { get; set; }
                public string OwnerName { get; set; }
                public string ContactNo { get; set; }
            }

            public class ParkingSpace<T, A> : ticket<T, A>
            {
                public int NOOFSPACE { get; set; }
            }

            public class ParkingTicket<T, A> : ticket<T, A>
            {
                public int VehicleID { get; set; }
                public int SpaceID { get; set; }
                public A EntryDateTime { get; set; }
                public A ExitDateTime { get; set; }
            }

            public class TotalAmount<T, A> : ticket<T, A>
            {
                public int TicketID { get; set; }
                public string VehicleName { get; set; }
                public string Amount { get; set; }
                public string ParkingDuration { get; set; }
                
            }
        }
    }
}
