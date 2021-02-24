using ClassLibrary.DAL;
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

            // Tab 2: "It should also be used when guests check in and out."
            // Liste over reservasjoner som ikkje har sjekka inn
            // Lister over gjester på hotellet som har sjekka inn
            // Dobbeltklikke for å endre status? Må muligens ha egen editor her og.

            // Tab 3: "This program should also be used to register room service and maintenance requests for rooms"
            // Lister over alle Tasks, kanskje sortert på type?
            // Felter og knapp for å legge til nye Tasks.
            rooms = dx.Rooms;
            reservations = dx.Reservations;
            tasks = dx.Tasks;
            customers = dx.Customers;

            //Room r1 = new Room { RoomNumber = 9, NumberOfBeds = 3, Quality = "High", CheckedIn = false, Rid = 0 };
            //dx.Rooms.Add(r1);
            reservations.Load();
            customers.Load();

            ReservationsList.DataContext = reservations.Local;
        }


    }
}