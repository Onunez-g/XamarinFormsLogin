using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginSignUpPages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoverView : ContentView
    {
        

        public DiscoverView()
        {
            InitializeComponent();
            BindingContext = this;
        }
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

        private void OnTappedCardView(object sender, EventArgs e)
        {
            CardV.BackgroundColor = CardV.BackgroundColor == Color.White ? Color.Yellow : Color.White;
        }
    }
}