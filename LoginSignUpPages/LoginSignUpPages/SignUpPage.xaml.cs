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
        public SignUpPage()
        {
            InitializeComponent();
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
    }
}