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
        private int laskuri;
        public App()
        {
            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 23);

            //painonapin alustus
            Button arvaaNappi = new Button();
            arvaaNappi.Text = "Arvaa";
            arvaaNappi.Clicked += arvaaNappi_Clicked;

            syötekenttä = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Text = ""
            };
            arvauksenTulosLabel = new Label();
            arvauksenTulosLabel.Text = "";
            laskuri = 0;

            MainPage = new EkaSivu();

            //The root page of your application omaaaaa....
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        //VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Eka mobiiliAppsi",
            //                TextColor = Color.Yellow
            //            },

            //            new Label {
            //                HorizontalTextAlignment = TextAlignment.Center,
            //                Text = "Versio 0,002",
            //                TextColor = Color.Silver
            //            },

            //            syötekenttä,
            //            arvaaNappi,
            //            arvauksenTulosLabel
            //        }
            //    }
            //};
        }

        private void arvaaNappi_Clicked(object sender, EventArgs e)
        {
            laskuri = laskuri + 1;
            int arvaus = int.Parse(syötekenttä.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on suurempi kuin " + arvaus.ToString() + " (" + laskuri.ToString() + ")";
                syötekenttä.Text = "";
                syötekenttä.Focus();
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on pienempi kuin " + arvaus.ToString() + " (" + laskuri.ToString() +")";
                syötekenttä.Text = "";
                syötekenttä.Focus();

            }
            else if (arvaus == oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Jee - tismalleen! Arvasit " + laskuri.ToString() + " kertaa";
                Random rnd = new Random();
                oikeaLuku = rnd.Next(1, 21);
                syötekenttä.Text = "";
                syötekenttä.Focus();
                laskuri = 0;
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
