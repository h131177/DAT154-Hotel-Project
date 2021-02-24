using ClassLibrary.DAL;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
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
        private HotelContext dx;
        private Reservation r;

        public Editor()
        {
            InitializeComponent();
        }

        public Editor(HotelContext x) : this()
        {
            dx = x;
        }

        public Editor(HotelContext x, Reservation r) : this()
        {
            dx = x;
            ridText.Text = r.ReservationNumber.ToString();
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
    }
}
