using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<TESHDatos> Items { get; set; }
        SQLiteConnection database;

        public DataPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            database = new SQLiteConnection(db);
            database.CreateTable<TESHDatos>();
            Items = new ObservableCollection<TESHDatos>(database.Table<TESHDatos>());
            BindingContext = this;
        }
        private void Evento_Insertar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Insert_Page());
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new Select_Page(e.SelectedItem as TESHDatos));
        }
    }
}