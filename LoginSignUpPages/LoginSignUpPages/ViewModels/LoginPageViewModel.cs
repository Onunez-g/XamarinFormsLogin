using LoginSignUpPages.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginSignUpPages.ViewModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        public User User { get; set; } = new User();
        public bool IsPassword { get; set; } = true;
        public string PassImg { get; set; } = "VisiblePass";
        public ICommand LoginCommand { get; set; }
        public ICommand GoToSignUpCommand { get; set; }
        public ICommand ShowPasswordCommand { get; set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                if(string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Fields are required", "Ok");
                    return;
                }
                await App.Current.MainPage.Navigation.PushModalAsync(new MenuPage(), false);
            });
            GoToSignUpCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage(User.UserName));
            });
            ShowPasswordCommand = new Command(() =>
            {
                IsPassword = !IsPassword;
                PassImg = IsPassword ? "VisiblePass" : "HidePass";
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
