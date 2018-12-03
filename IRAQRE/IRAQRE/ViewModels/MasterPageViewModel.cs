using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IRAQRE.ViewModels
{
    public class MasterPageViewModel : INotifyPropertyChanged
    {
        #region Command
        public ICommand LoginTapped { get; set; }
        public ICommand SignupTapped { get; set; }
        public ICommand HomePageTapped { get; set; }
        public ICommand SearchTapped { get; set; }
        public ICommand WishlistTapped { get; set; }
        public ICommand BuyTapped { get; set; }
        public ICommand RentTapped { get; set; }
        public ICommand AccountTapped { get; set; }
        public ICommand SettingsTapped { get; set; }
        #endregion

        #region Private Command Method
        private void Settings_Tapped(object obj)
        {

        }

        private void Account_Tapped(object obj)
        {

        }

        private void Rent_Tapped(object obj)
        {

        }

        private void Buy_Tapped(object obj)
        {

        }

        private void Wishlist_Tapped(object obj)
        {

        }

        private void Search_Tapped(object obj)
        {

        }

        private void HomePage_Tapped(object obj)
        {

        }

        private void Signup_Tapped(object obj)
        {

        }

        private void Login_Tapped(object obj)
        {

        }
        #endregion

        #region Consructor
        public MasterPageViewModel()
        {
            LoginTapped = new Command(Login_Tapped);
            SignupTapped = new Command(Signup_Tapped);
            HomePageTapped = new Command(HomePage_Tapped);
            SearchTapped = new Command(Search_Tapped);
            WishlistTapped = new Command(Wishlist_Tapped);
            BuyTapped = new Command(Buy_Tapped);
            RentTapped = new Command(Rent_Tapped);
            AccountTapped = new Command(Account_Tapped);
            SettingsTapped = new Command(Settings_Tapped);
        }
        #endregion

        #region Notify Propert Changed
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
