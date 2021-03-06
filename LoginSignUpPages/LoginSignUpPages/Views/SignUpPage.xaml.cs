﻿using LoginSignUpPages.ViewModels;
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
            BindingContext = new SignUpPageViewModel(name);
        }
    }
}