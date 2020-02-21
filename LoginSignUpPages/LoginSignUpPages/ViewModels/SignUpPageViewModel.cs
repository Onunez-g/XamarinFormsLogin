using LoginSignUpPages.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginSignUpPages.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {
        public NewUser User { get; set; } = new NewUser();
        public bool IsPassword { get; set; } = true;
        public bool IsPasswordRepeat { get; set; } = true;
        public string PassImg { get; set; } = "VisiblePass";
        public string PassRepeatImg { get; set; } = "VisiblePass";
        public ICommand SignUpCommand { get; set; }
        public ICommand GoToLoginCommand { get; set; }
        public ICommand ShowPasswordCommand { get; set; }
        public SignUpPageViewModel(string name)
        {
            User.Name = name;
            SignUpCommand = new Command(async () => 
            {
                if(string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.RepeatPassword))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "All fields are required", "Ok");
                    return;
                }
                await App.Current.MainPage.Navigation.PushModalAsync(new MenuPage(), false);
            });
            GoToLoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PopModalAsync();
            });
            ShowPasswordCommand = new Command<int>((num) =>
            {
                switch(num)
                {
                    case 1:
                        IsPassword = !IsPassword;
                        PassImg = IsPassword ? "VisiblePass" : "HidePass";
                        break;
                    case 2:
                        IsPasswordRepeat = !IsPasswordRepeat;
                        PassRepeatImg = IsPasswordRepeat ? "VisiblePass" : "HidePass";
                        break;
                }
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
