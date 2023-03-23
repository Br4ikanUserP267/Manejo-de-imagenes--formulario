using parcial.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detalle : ContentPage
    {
        public Contactos contactos { get; set; }
        public detalle()
        {
            InitializeComponent();
            contactos = new Contactos();
            this.BindingContext = contactos;
        }

        public detalle(Contactos contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
            this.BindingContext = contactos;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new formulario(contactos));
        }
    }
}