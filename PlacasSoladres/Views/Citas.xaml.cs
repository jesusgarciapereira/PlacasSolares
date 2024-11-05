using Citas;
using PlacasSoladres.Models;
using System.Collections.ObjectModel;

namespace PlacasSoladres.Views;

public partial class Citas : ContentPage
{
		/// <summary>
		/// Inicializamos lista con la funcion get Listas
		/// </summary>
		public ObservableCollection<Cita> lista = CitasVM.getCitas();
		
	public Citas()
	{
		InitializeComponent();

	}

	/// <summary>
	/// Funcion que cuando se selecciona una cita, se va a otra vista con la cita seleccionada
	/// </summary>
	/// <param name="obj"></param>
	/// <param name="e"></param>
	public async void onItemSelecter(object obj, SelectedItemChangedEventArgs e){

		if (e.SelectedItem is Cita cita)
		{
			await Navigation.PushAsync(new DetallesCitas(cita));
		}
	}
}