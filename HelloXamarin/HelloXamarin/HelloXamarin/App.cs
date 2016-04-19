using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class App : Application
    {
        private Entry syötekenttä;
        private Label arvauksenTulosLabel;
        private int oikeaLuku;
        public App()
        {
            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 23);

            //painonapin alustus
            Button arvaaNappi = new Button();
            arvaaNappi.Text = "Arvaa";
            arvaaNappi.Clicked += arvaaNappi_Clicked;
            // The root page of your application omaaaaa....
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    //VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Eka mobiiliAppsi",
                            TextColor = Color.Yellow
                        },

                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Versio 0,002",
                            TextColor = Color.Silver
                        },

                        syötekenttä,
                        arvaaNappi,
                        arvauksenTulosLabel
                    }
                }
            };
        }

        private void arvaaNappi_Clicked(object sender, EventArgs e)
        {
            int arvaus = int.Parse(syötekenttä.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on suurempi";
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on pienempi";
            }
            else if (arvaus == oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Jee - tismalleen!";
                Random rnd = new Random();
                oikeaLuku = rnd.Next(1, 21);
            }
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
