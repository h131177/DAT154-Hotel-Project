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
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        private HotelContext dx = new HotelContext();
        private DbSet<Reservation> reservations;

        public Editor()
        {
            InitializeComponent();
        }

        public Editor(HotelContext x) : this()
        {
            dx = x;
        }

        public Editor(HotelContext x, Reservation r, DbSet<Reservation> res, DbSet<Room> rooms) : this()
        {
            dx = x;
            List<int> availableRooms = new List<int>();
            reservations = res;

            var rl = rooms.Select(room => new { room.RoomNumber });

            foreach (var room in rl)
            {
                //Må legge inn kode her som sjekker om rommene er ledig
                availableRooms.Add(room.RoomNumber);
            }

            
            ridText.Text = r.ReservationNumber.ToString();
            comboBox.DataContext = availableRooms;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int rid = int.Parse(ridText.Text);
            Reservation res = dx.Reservations.Where(r => r.ReservationNumber == rid).FirstOrDefault();

            if(res != null)
            {
                dx.Reservations.Remove(res);
                dx.SaveChanges();
            }
        }

        private void addRoomButton_Click(object sender, RoutedEventArgs e)
        {
            int nr = int.Parse(ridText.Text);
            Reservation res = dx.Reservations.Where(r => r.ReservationNumber == nr).FirstOrDefault();
            
            if (res != null)
            {
                if (!comboBox.Text.Equals("")) res.RoomNumber = int.Parse(comboBox.Text);
                dx.SaveChanges();
            }
            //Viewet blir ikkje oppdatert, men databasen blir
        }
    }
}
