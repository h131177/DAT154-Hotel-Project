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
            new Room{RoomNumber=1,NumberOfBeds=1, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=2,NumberOfBeds=1, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=3,NumberOfBeds=2, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=4,NumberOfBeds=2, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=5,NumberOfBeds=2, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=6,NumberOfBeds=3, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=7,NumberOfBeds=3, Quality="High", CheckedIn=false, Rid=0},
            new Room{RoomNumber=8,NumberOfBeds=3, Quality="High", CheckedIn=false, Rid=0}
            };

            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var reservations = new List<Reservation>
            {
            new Reservation{ReservationNumber=1,ArrivalDay=new DateTime(2021,2,2), DepartureDay=new DateTime(2021,3,2), Price=500, Cid=1, RoomNumber=0},
            new Reservation{ReservationNumber=2,ArrivalDay=new DateTime(2021,4,2), DepartureDay=new DateTime(2021,5,2), Price=500, Cid=2, RoomNumber=0},
            new Reservation{ReservationNumber=3,ArrivalDay=new DateTime(2021,6,2), DepartureDay=new DateTime(2021,8,2), Price=1000, Cid=3, RoomNumber=0},
            new Reservation{ReservationNumber=4,ArrivalDay=new DateTime(2021,8,2), DepartureDay=new DateTime(2021,10,2), Price=1000, Cid=4, RoomNumber=0},
            };

        rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();
            /*var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Teoretisk Kjemi"},
            new Course{CourseID=4022,Title="Java for Dummies"},
            new Course{CourseID=4041,Title="Funksjonell Programmering for Kjøleskap"},
            new Course{CourseID=1045,Title="Matte VII"},
            new Course{CourseID=3141,Title="Pubrunde"},
            new Course{CourseID=2021,Title="Praktisk Dataspilling"},
            new Course{CourseID=2042,Title="Kattegjeting"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Grade>
            {
            new Grade{StudentID=1,CourseID=1050,Grade_=GradeEnum.A},
            new Grade{StudentID=1,CourseID=4022,Grade_=GradeEnum.C},
            new Grade{StudentID=1,CourseID=4041,Grade_=GradeEnum.B},
            new Grade{StudentID=2,CourseID=1045,Grade_=GradeEnum.B},
            new Grade{StudentID=2,CourseID=3141,Grade_=GradeEnum.F},
            new Grade{StudentID=2,CourseID=2021,Grade_=GradeEnum.F},
            new Grade{StudentID=3,CourseID=1050},
            new Grade{StudentID=4,CourseID=1050,},
            new Grade{StudentID=4,CourseID=4022,Grade_=GradeEnum.F},
            new Grade{StudentID=5,CourseID=4041,Grade_=GradeEnum.C},
            new Grade{StudentID=6,CourseID=1045},
            new Grade{StudentID=7,CourseID=3141,Grade_=GradeEnum.A},
            };
            enrollments.ForEach(s => context.Grades.Add(s));
            context.SaveChanges();
            */
        }

    }
}