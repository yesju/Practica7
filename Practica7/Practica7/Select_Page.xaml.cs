using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Select_Page : ContentPage
    {
        SQLiteConnection database;

        public Select_Page(object selectedItem)
        {
           
            var dato = selectedItem as TESHDatos;
            BindingContext = dato;
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            database = new SQLiteConnection(db);

            string[] uno = { "Primero", "Segundo"};
            Picker_semestre.ItemsSource = uno;
            Picker_semestre.SelectedItem = dato.Semestre;
        }
        private void Button_Actualizar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                ID = Convert.ToInt32(Entry_ID.Text),
                Nombre = Entry_Nombre.Text,
                Apellido = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Convert.ToInt32(Entry_Telefono.Text),
                Carrera = Entry_Carrera.Text,
                Semestre = Convert.ToString(Picker_semestre.SelectedItem),
                Correo = Entry_Correo.Text,
                GitHub = Entry_GitHub.Text
            };
            database.Update(datos);
            Navigation.PushAsync(new DataPage());
        }
        private void Button_Eliminar_Clicked(object sender, EventArgs e)
        {
            var datos = new TESHDatos
            {
                ID = Convert.ToInt32(Entry_ID.Text),
                Nombre = Entry_Nombre.Text,
                Apellido = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Convert.ToInt32(Entry_Telefono.Text),
                Carrera = Entry_Carrera.Text,
                Semestre = Convert.ToString(Picker_semestre.SelectedItem),
                Correo = Entry_Correo.Text,
                GitHub = Entry_GitHub.Text

            };
            database.Delete(datos);
            Navigation.PushAsync(new DataPage());
        }
    }
}