﻿using ClassLibrary.DAL;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private HotelContext dx = new HotelContext();

        private DbSet<Room> rooms;
        private DbSet<Reservation> reservations;
        private DbSet<ClassLibrary.Models.Task> tasks;
        private DbSet<Customer> customers;


        public MainWindow()
        {
            InitializeComponent();

            // Tab 1: "add new reservations and delete reservations and associate a reservation with a particular room."
            // Liste over alle reservasjoner, kan dobbeltklikke på ein reservasjon for å få opp
            // ein editor der ein kan slette og velge rom. Dropdown list som viser ledige rom.
            // I den editoren trenger ein 2 knapper, slett og velg rom.
            // Trenger også liste over alle ledige rom den dagen, slik at resepsjonist kan dobbeltklikke
            // på et rom for å booke til nye gjester, dette vil også kjøre ein metode for å beregne pris.
            // Dobbeltklikk gir ein ny editor med felter for å reservere rom, trenger ein knapp reserver.

            rooms = dx.Rooms;
            reservations = dx.Reservations;
            tasks = dx.Tasks;
            customers = dx.Customers;

            reservations.Load();
            customers.Load();
            rooms.Load();
            tasks.Load();

            ReservationsList.DataContext = reservations.Local;
            CheckInList.DataContext = reservations.Local;
            AvailableRoomsList.DataContext = rooms.Local;
            TasksList.DataContext = tasks.Local;

            //addTask.MouseDown += AddTask_MouseDown;

            List<int> availableRooms = new List<int>();

            var rl = rooms.Select(room => new { room.RoomNumber });

            foreach (var room in rl)
            {
                //Må legge inn kode her som sjekker om rommene er ledig
                availableRooms.Add(room.RoomNumber);
            }
            taskroomNr.DataContext = availableRooms;
            taskType.DataContext = Enum.GetValues(typeof(ClassLibrary.Models.Type));
            taskStatus.DataContext = Enum.GetValues(typeof(Status));
        }

        private void ReservationsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Reservation r = (Reservation)ReservationsList.SelectedItem;

            new Editor(dx, r, reservations, rooms).ShowDialog();
        }

        private void CheckInList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Reservation rs = (Reservation)CheckInList.SelectedItem;
            int id = rs.ReservationNumber;
            
            Reservation res = dx.Reservations.Where(r => r.ReservationNumber == id).FirstOrDefault();

            if (res != null)
            {
                res.C.CheckedIn = !res.C.CheckedIn;
                dx.SaveChanges();
            }
            //Viewet blir ikkje oppdatert, men databasen blir
        }

        private void AvailableRoomsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Room r = (Room)AvailableRoomsList.SelectedItem;
            new EditorBook(dx, r).ShowDialog();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {

            int rNr = int.Parse(taskroomNr.Text);
            ClassLibrary.Models.Type type = (ClassLibrary.Models.Type)taskType.SelectedValue;
            Status status = (Status)taskStatus.SelectedValue;
            string task = taskTask.Text;


            ClassLibrary.Models.Task task1 = new ClassLibrary.Models.Task { Roomnr = rNr, Type = type, Task_ = task, Note = "", Status = status, Eid = 0 };
            dx.Tasks.Add(task1);
            dx.SaveChanges();   
        }
    }
}