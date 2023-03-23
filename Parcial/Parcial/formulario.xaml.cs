using Parcial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace parcial.models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class formulario : ContentPage
    {
        public Contactos contactos { get; set; }
        public formulario()
        {
            InitializeComponent();
            BindingContext = new FotoViewModel();
            contactos = new Contactos();
            this.BindingContext = contactos;
        }
        public formulario(Contactos contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
            this.BindingContext = contactos;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (App.ListadoContactos.Contains(contactos))
            {
                Navigation.PushAsync(new MainPage(contactos));
            }
            else
            {
                App.ListadoContactos.Add(contactos);
            }
            Navigation.PushAsync(new MainPage(contactos));
        }
    }
}