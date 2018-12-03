using IRAQRE.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IRAQRE.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private ObservableCollection<HomePageModel> _realEstateList = new ObservableCollection<HomePageModel>();
        public HomePageModel _selectedRealEstate = new HomePageModel();

        private bool _isListViewVisible;
        private bool _isGridViewVisible;
        private bool _isThumbnailViewVisible;
        private bool _isFloatingActionVisible;

        private string _listviewIcon = "icon_2_active.png";
        private string _thumbnailviewIcon = "icon_3.png";
        private string _gridviewIcon = "icon_1.png";
        #endregion

        #region Public Variables
        public ObservableCollection<HomePageModel> RealEstateList
        {
            get { return _realEstateList; }
            set { _realEstateList = value; OnPropertyChanged("RealEstateList"); }
        }

        public HomePageModel SelectedRealEstate
        {
            get { return _selectedRealEstate; }
            set { _selectedRealEstate = value; OnPropertyChanged("SelectedRealEstate");}
        }

        public bool IsListViewVisible
        {
            get { return _isListViewVisible; }
            set { _isListViewVisible = value; OnPropertyChanged("IsListViewVisible"); }
        }

        public bool IsGridViewVisible
        {
            get { return _isGridViewVisible; }
            set { _isGridViewVisible = value; OnPropertyChanged("IsGridViewVisible"); }
        }

        public bool IsThumbnailViewVisible
        {
            get { return _isThumbnailViewVisible; }
            set { _isThumbnailViewVisible = value; OnPropertyChanged("IsThumbnailViewVisible"); }
        }

        public bool IsFloatingActionVisible
        {
            get { return _isFloatingActionVisible; }
            set { _isFloatingActionVisible = value; OnPropertyChanged("IsFloatingActionVisible"); }
        }

        public string ListviewIcon
        {
            get { return _listviewIcon; }
            set { _listviewIcon = value; OnPropertyChanged("ListviewIcon"); }
        }

        public string ThumbnailviewIcon
        {
            get { return _thumbnailviewIcon; }
            set { _thumbnailviewIcon = value; OnPropertyChanged("ThumbnailviewIcon"); }
        }

        public string GridviewIcon
        {
            get { return _gridviewIcon; }
            set { _gridviewIcon = value; OnPropertyChanged("GridviewIcon"); }
        }
        #endregion

        #region Command
        public ICommand ListViewDisplayCommand { get; set; }
        public ICommand ThumbnailViewDisplayCommand { get; set; }
        public ICommand GridViewDisplayCommand { get; set; }
        public ICommand FilterCommand { get; set; }
        public ICommand SettingIconTapped { get; set; }
        public ICommand SortingCommand { get; set; }
        public ICommand MapShowCommand { get; set; }
        public ICommand CallClicked { get; set; }
        public ICommand EmailClicked { get; set; }
        #endregion

        #region Command Private Method
        private void ListViewDisplay_Command(object obj)
        {
            IsListViewVisible = true;
            IsGridViewVisible = false;
            IsThumbnailViewVisible = false;
            IsFloatingActionVisible = true;

            GridviewIcon = "icon_1.png";
            ListviewIcon = "icon_2_active.png";
            ThumbnailviewIcon = "icon_3.png";
        }

        private void ThumbnailViewDisplay_Command(object obj)
        {
            IsListViewVisible = false;
            IsGridViewVisible = false;
            IsThumbnailViewVisible = true;
            IsFloatingActionVisible = false;

            GridviewIcon = "icon_1.png";
            ListviewIcon = "icon_2.png";
            ThumbnailviewIcon = "icon_3_active.png";
        }

        private void GridViewDisplay_Command(object obj)
        {
            IsListViewVisible = false;
            IsGridViewVisible = true;
            IsThumbnailViewVisible = false;
            IsFloatingActionVisible = true;

            GridviewIcon = "icon_1_active.png";
            ListviewIcon = "icon_2.png";
            ThumbnailviewIcon = "icon_3.png";
        }

        private void Filter_Command(object obj)
        {

        }

        private void SettingIcon_Tapped(object obj)
        {

        }

        private void MapShow_Command(object obj)
        {

        }

        private void Sorting_Command(object obj)
        {

        }

        private void Email_Clicked(object obj)
        {

        }

        private void Call_Clicked(object obj)
        {

        }
        #endregion

        #region Construtor
        public HomePageViewModel()
        {
            ListViewDisplayCommand = new Command(ListViewDisplay_Command);
            ThumbnailViewDisplayCommand = new Command(ThumbnailViewDisplay_Command);
            GridViewDisplayCommand = new Command(GridViewDisplay_Command);
            FilterCommand = new Command(Filter_Command);
            SettingIconTapped = new Command(SettingIcon_Tapped);
            SortingCommand = new Command(Sorting_Command);
            MapShowCommand = new Command(MapShow_Command);
            CallClicked = new Command(Call_Clicked);
            EmailClicked = new Command(Email_Clicked);

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa1.png",
                HomePrice = "147000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa2.png",
                HomePrice = "97000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa3.png",
                HomePrice = "159000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa4.png",
                HomePrice = "71000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa5.png",
                HomePrice = "84000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa6.png",
                HomePrice = "147000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa7.png",
                HomePrice = "284000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });

            RealEstateList.Add(new HomePageModel
            {
                Image = "villa8.png",
                HomePrice = "197000",
                HomeType = "Villa",
                BedroomNumber = "5",
                WashroomNumber = "6",
                Address = "Arabian Style, AI Reef Villas, AI Reef Abu Dhabi"
            });
            IsListViewVisible = true;
            IsGridViewVisible = false;
            IsThumbnailViewVisible = false;
            IsFloatingActionVisible = true;
        }
      
        #endregion

        #region Notify Property Change Method
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
