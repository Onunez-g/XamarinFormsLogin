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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string name)
        {
            InitializeComponent();
            signupEmail.Text = name;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            signupPass.IsPassword = !signupPass.IsPassword;
            visibleIcon1.Source = signupPass.IsPassword ? "VisiblePass" : "HidePass";
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            signupRepeat.IsPassword = !signupRepeat.IsPassword;
            visibleIcon2.Source = signupRepeat.IsPassword ? "VisiblePass" : "HidePass";
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(signupEmail.Text) || string.IsNullOrEmpty(signupUser.Text) || string.IsNullOrEmpty(signupPass.Text) || string.IsNullOrEmpty(signupRepeat.Text))
            {
                await DisplayAlert("Error", "All fields are required", "Cancel");
                return;
            }
            await Navigation.PushModalAsync(new MenuPage(), false);
        }
    }
}