using parcial.models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace parcial
{
    public partial class App : Application
    {
        public static ObservableCollection<Contactos> ListadoContactos;
        public App()
        {
            InitializeComponent();

            ListadoContactos = new ObservableCollection<Contactos>();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
