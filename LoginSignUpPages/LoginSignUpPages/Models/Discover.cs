using LoginSignUpPages.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LoginSignUpPages.Models
{
    public class Discover: BindableObject
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(
            "CardTitle",
            typeof(string),
            typeof(DiscoverView),
            string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(
            "CardDescription",
            typeof(string),
            typeof(DiscoverView),
            string.Empty);
        public static readonly BindableProperty IconSourceImageProperty = BindableProperty.Create(
            "IconImageSource",
            typeof(ImageSource),
            typeof(DiscoverView));
        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }
        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }
        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(IconSourceImageProperty);
            set => SetValue(IconSourceImageProperty, value);
        }
    }
}
