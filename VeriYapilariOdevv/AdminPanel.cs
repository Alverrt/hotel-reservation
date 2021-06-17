using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriYapilariOdevv.Controllers;
using VeriYapilariOdevv.Helpers;
using VeriYapilariOdevv.Models;
using VeriYapilariOdevv.ORM;

namespace VeriYapilariOdevv
{
    public partial class AdminPanel : Form
    {
        HotelController HotelController = new HotelController();
        RoomController RoomController = new RoomController();
        TextBoxCleaner cleaner = new TextBoxCleaner();

        private object HotelID;
        private object RoomID;
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            HotelAddTabControl.Appearance = TabAppearance.FlatButtons;
            HotelAddTabControl.ItemSize = new Size(0, 1);
            HotelAddTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void AddNewHoteButton_Click(object sender, EventArgs e)
        {
            AdminPanelTabControl.SelectedTab = AddHotelPage;
        }

        private void GetHotelsButton_Click(object sender, EventArgs e)
        {
            HotelORM orm = new HotelORM();
            List<HotelModel> list = HotelController.GetHotels();
            var bindingList = new BindingList<HotelModel>(list);
            var source = new BindingSource(bindingList, null);
            HotelsDataGridView.DataSource = source;
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelReservationForm MainMenu = new HotelReservationForm();
            MainMenu.Show();
        }

        private void BackToAdminMainMenuButton_Click(object sender, EventArgs e)
        {
            AdminPanelTabControl.SelectedTab = AdminMainMenuPage;
        }

        private void BackToAdminMainMenuButton2_Click(object sender, EventArgs e)
        {
            AdminPanelTabControl.SelectedTab = AdminMainMenuPage;
        }

        private void AddHotel_NextButton1_Click(object sender, EventArgs e)
        {
            HotelModel model = new HotelModel();

            model.HotelName = AddHotel_HotelNameTxtBox.Text;
            model.Province = AddHotel_ProvinceTxtBox.Text;
            model.Town = AddHotel_TownTxtBox.Text;
            model.Adress = AddHote_AdressTxtBox.Text;
            model.Email = AddHotel_EmailTxtBox.Text;
            model.PhoneNumber = AddHotel_PhoneNumberTxtBox.Text;
            model.NumberOfRooms = Convert.ToInt32(AddHotel_NumberOfRoomsTxtBox.Text);
            model.Stars = Convert.ToInt32(AddHotel_StarsTxtBox.SelectedItem);

            this.HotelID = HotelController.AddHotel(model);

            HotelAddTabControl.SelectedTab = RoomDetailsTabPage;
        }

        private void AddHotel_SaveButton2_Click(object sender, EventArgs e)
        {
            RoomModel model = new RoomModel();
            model.RoomNo = Convert.ToInt32(RoomDetails_RoomNoTxtBox.Text);
            model.PhoneNumber = RoomDetails_RoomPhoneNumberTxtBox.Text;
            model.RoomCapaticy = Convert.ToInt32(RoomDetails_RoomSizeTxtBox.Text);
            model.RoomView = RoomDetails_RoomViewTxtBox.Text;
            model.Availability = RoomDetails_RoomAvailabilitySelectBox.SelectedIndex;
            model.Price = Convert.ToInt32(RoomDetails_RoomPriceTxtBox.Text);
            model.HotelID = Convert.ToInt32(HotelID);

            this.RoomID = RoomController.AddRoom(model);

            cleaner.ClearTextBoxes(HotelAddTabControl.SelectedTab.Controls);
        }

        private void AddHotel_NextButton2_Click(object sender, EventArgs e)
        {
            HotelAddTabControl.SelectedTab = WorkerDetailsTabPage;
        }

        private void AddHotel_SaveButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
