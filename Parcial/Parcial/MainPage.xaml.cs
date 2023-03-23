using parcial.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace parcial
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Contactos> ListadoContactos { get; set; }
        public Contactos contactos { get; set; }
        
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public MainPage(Contactos contactos)
        {
            InitializeComponent();
            this.contactos = contactos;
            ListadoContactos = App.ListadoContactos;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new detalle(contactos));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new formulario());
        }

        private void listado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listado.SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string buscarTexto = buscar.Text;

            if (string.IsNullOrEmpty(buscarTexto))
            {
                // Si no hay texto de búsqueda, mostrar todos los elementos.
                listado.ItemsSource = ListadoContactos;
            }
            else
            {
                // Filtrar los elementos en base al texto de búsqueda.
                var filtro = ListadoContactos.Where(i => i.titulo.Contains(buscarTexto));
                listado.ItemsSource = filtro.ToList(); // Actualizar la fuente de datos
            }
        }
    }
}
