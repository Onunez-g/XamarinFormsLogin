using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginSignUpPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            loginPass.IsPassword = !loginPass.IsPassword;
            visibleIcon.Source = loginPass.IsPassword ? "VisiblePass" : "HidePass";
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUpPage(loginUser.Text));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginUser.Text) || string.IsNullOrEmpty(loginPass.Text))
            {
                await DisplayAlert("Error", "Username and password are required", "cancel");
                return;
            }
            await Navigation.PushModalAsync(new MenuPage(), false);

        }
    }
}