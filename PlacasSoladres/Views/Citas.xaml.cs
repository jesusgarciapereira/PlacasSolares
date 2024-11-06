using Citas;
using PlacasSoladres.Models;
using System.Collections.ObjectModel;

namespace PlacasSoladres.Views;

public partial class Citas : ContentPage
{
    /// <summary>
    /// Inicializamos lista con la funcion obtenerCitas
    /// </summary>
    public ObservableCollection<Cita> lista = CitasVM.obtenerCitas();
		
	public Citas()
	{
		InitializeComponent();

	}

	/// <summary>
	/// Evento asociado a seleccionar una cita, se va a otra vista con la cita seleccionada
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