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

            rooms = dx.Rooms;
            reservations = dx.Reservations;
            tasks = dx.Tasks;
            customers = dx.Customers;

            reservations.Load();
            customers.Load();

            ReservationsList.DataContext = reservations.Local;
            CheckInList.DataContext = reservations.Local;
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

        private void availableRoomsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}