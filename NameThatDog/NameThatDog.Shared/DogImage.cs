using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace NameThatDog.Shared
{
    public class DogImage : INotifyPropertyChanged
    {
        private string initialSource = "/Assets/Dogs/swimmerboi.jpg";
        public string ImageName
        {
            get
            {
                return initialSource;
            }
            set
            {
                initialSource = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageName)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GetDogImage()
        {
            string commonPath = "/Assets/Dogs/";
            var dogImageNames = new List<string> { "happyboi.jpg", "peakingboi.jpg", "swimmerboi.jpg", "tinyboi.jpg", "treatcatchboi.jpg", "wavingboi.jpg" };
            var random = new Random();
            int index = random.Next(dogImageNames.Count);
            ImageName = commonPath + dogImageNames[index];
        }
    }
}
