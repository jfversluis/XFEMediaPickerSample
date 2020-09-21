using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFEMediaPickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick a photo"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();

                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }

        async void Button1_Clicked(System.Object sender, System.EventArgs e)
        {
            var result = await MediaPicker.CapturePhotoAsync();

            if (result != null)
            {
                var stream = await result.OpenReadAsync();

                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }
    }
}
