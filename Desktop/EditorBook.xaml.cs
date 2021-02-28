using System;
using ClassLibrary.DAL;
using ClassLibrary.Models;
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
    /// Interaction logic for EditorBook.xaml
    /// </summary>
    public partial class EditorBook : Window
    {
        private HotelContext dx = new HotelContext();


        public EditorBook()
        {
            InitializeComponent();
        }
        public EditorBook(HotelContext x, Room r) : this()
        {
            dx = x;
            roomNumberTextbox.Text = r.RoomNumber.ToString();
            numberOfBedsTextbox.Text = r.NumberOfBeds.ToString();
            qualityTextbox.Text = r.Quality;
            nameTextbox.Text = "";
            addressTextbox.Text = "";
            zipCodeTextbox.Text = "";
            checkInDate.DisplayDateStart = DateTime.Today;
            checkInDate.SelectedDate = DateTime.Today;
            checkOutDate.DisplayDateStart = DateTime.Today;
            checkOutDate.SelectedDate = DateTime.Today;
        }
        private void bookButton_Click(object sender, RoutedEventArgs e)
        {
            //customer

            string name = nameTextbox.Text;
            string address = addressTextbox.Text;
            int zipCode = int.Parse(zipCodeTextbox.Text);
            string password = passwordBox.ToString();
            bool checkedIn = false;

            Customer cust = new Customer{Name = name, Address = address, ZipCode = zipCode, Password = password, CheckedIn = checkedIn};

            DateTime checkIn = checkInDate.SelectedDate.Value.Date;
            DateTime checkOut= checkOutDate.SelectedDate.Value.Date;

            int number = int.Parse(roomNumberTextbox.Text);
            Room rm = dx.Rooms.Where(r => r.RoomNumber == number).FirstOrDefault();
            int price = 500;

            Reservation rs = new Reservation { ArrivalDay = checkIn, DepartureDay = checkOut, Price = price, C = cust, Room = rm };


            dx.Reservations.Add(rs);
            dx.SaveChanges();


        }
    }
}
