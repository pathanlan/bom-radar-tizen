using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PTHCom.BoMRadarTizen.UI
{
    public class App : Application
    {
        public App()
        {
            var imageGrid = new Grid
            {
                ColumnDefinitions = { new ColumnDefinition() },
                RowDefinitions = { new RowDefinition() }
            };

            imageGrid.Children.Add(new Image
            {
                Source = ImageSource.FromFile("background.png")
            });

            imageGrid.Children.Add(new Image
            {
                Source = ImageSource.FromFile("radar.png")
            });

            imageGrid.Children.Add(new Image
            {
                Source = ImageSource.FromFile("locations.png")
            });

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        imageGrid
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
