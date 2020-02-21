using LoginSignUpPages.Models;
using LoginSignUpPages.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginSignUpPages.ViewModels
{
    class DiscoverViewViewModel: INotifyPropertyChanged
    {
        public Discover Discover { get; set; } = new Discover();
        public Color FrameColor { get; set; } = Color.White;
        public ICommand ChangeFrameColor { get; set; }
        public DiscoverViewViewModel()
        {
            ChangeFrameColor = new Command(() =>
            {
                FrameColor = FrameColor == Color.White ? Color.LightYellow : Color.White;
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
