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
        public EditorBook(HotelContext x) : this()
        {
            dx = x;
        }

    }
}
