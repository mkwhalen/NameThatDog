using NameThatDog.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace NameThatDog
{
    public sealed partial class MainPage : Page
    {
        private readonly DogImage _randomDogImage = new DogImage();

        public MainPage()
        {
            this.InitializeComponent();
            dogImage.DataContext = _randomDogImage;
            _randomDogImage.GetDogImage();

        }
        void OnClick(object sender, RoutedEventArgs e)
        {
            var randomDogName = new DogName();

            dogNameText.Text = randomDogName.GetDogName();

        }

        void OnImageClick(object sender, RoutedEventArgs e)
        {
            _randomDogImage.GetDogImage();
        }

        void OnPlatformClick(object sender, RoutedEventArgs e)
        {
            #if NETFX_CORE
                        platformText.Text = "This is UWP!";
            #elif __WASM__
                        platformText.Text = "This is WebAssembly!";
            #elif __ANDROID__
                        platformText.Text = "This is Android!";
            #elif IOS
                        platformText.Text = "This is iOS!";
            #endif
        }
    }
}
