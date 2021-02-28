using ClassLibrary.Models;
using System;
using System.Collections.Generic;

namespace ClassLibrary.DAL
{
    public class HotelInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HotelContext>
    {
        protected override void Seed(HotelContext context)
        {
           
        var rooms = new List<Room>
            {
            new Room{RoomNumber=0,NumberOfBeds=0, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=1,NumberOfBeds=1, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=2,NumberOfBeds=1, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=3,NumberOfBeds=2, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=4,NumberOfBeds=2, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=5,NumberOfBeds=2, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=6,NumberOfBeds=3, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=7,NumberOfBeds=3, Quality="High", Reservations= new HashSet<Reservation>()},
            new Room{RoomNumber=8,NumberOfBeds=3, Quality="High", Reservations= new HashSet<Reservation>()}
            };

            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

        var customers = new List<Customer>
            {
            new Customer{ID=1,Name="Kjetil", Address="Testvei 1", ZipCode=5020, Password="Kjetil", CheckedIn=false},
            new Customer{ID=2,Name="Amalie", Address="Testvei 2", ZipCode=5020, Password="Amalie", CheckedIn=false},
            new Customer{ID=3,Name="Andrine", Address="Testvei 3", ZipCode=5020, Password="Andrine", CheckedIn=false},
            new Customer{ID=4,Name="Magnus", Address="Testvei 4", ZipCode=5020, Password="Magnus", CheckedIn=false},
            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();


        var reservations = new List<Reservation>
            {
            new Reservation{ReservationNumber=1,ArrivalDay=new DateTime(2021,2,2), DepartureDay=new DateTime(2021,3,2), Price=500, C=customers[0], Room=new Room()},
            new Reservation{ReservationNumber=2,ArrivalDay=new DateTime(2021,4,2), DepartureDay=new DateTime(2021,5,2), Price=500, C=customers[1], Room=new Room()},
            new Reservation{ReservationNumber=3,ArrivalDay=new DateTime(2021,6,2), DepartureDay=new DateTime(2021,8,2), Price=1000, C=customers[2], Room=new Room()},
            new Reservation{ReservationNumber=4,ArrivalDay=new DateTime(2021,8,2), DepartureDay=new DateTime(2021,10,2), Price=1000, C=customers[3], Room=new Room()},
            };

            reservations.ForEach(r => context.Reservations.Add(r));
            context.SaveChanges();

        var tasks = new List<Task>
            {
            new Task{ID=1,Roomnr=1, Type=Models.Type.MAINTAINCE, Task_="Broken Bed", Status=Status.NEW},
            new Task{ID=2,Roomnr=2, Type=Models.Type.SERVICE, Task_="Wine", Status=Status.NEW},
            new Task{ID=3,Roomnr=3, Type=Models.Type.CLEAN, Task_="Clean the room", Status=Status.NEW},
            new Task{ID=4,Roomnr=4, Type=Models.Type.SERVICE, Task_="Bike", Status=Status.NEW}
            };

            tasks.ForEach(t => context.Tasks.Add(t));
            context.SaveChanges();
        }

    }
}