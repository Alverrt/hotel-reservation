using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdevv
{
    public partial class HotelReservationForm : Form
    {
        public HotelReservationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hotelReservationControl.Appearance = TabAppearance.FlatButtons;
            hotelReservationControl.ItemSize = new Size(0, 1);
            hotelReservationControl.SizeMode = TabSizeMode.Fixed;

            FilterAndSortPage.Appearance = TabAppearance.FlatButtons;
            FilterAndSortPage.ItemSize = new Size(0, 1);
            FilterAndSortPage.SizeMode = TabSizeMode.Fixed;
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            hotelReservationControl.SelectedTab = HotelReservationTabPage;
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            hotelReservationControl.SelectedTab = MainMenuPage;
        }

        private void HotelsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // silll
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel panel = new AdminPanel();
            panel.Show();
        }
    }
}
