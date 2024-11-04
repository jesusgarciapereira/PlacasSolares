using Citas;
using PlacasSoladres.Models;
using System.Collections.ObjectModel;

namespace PlacasSoladres.Views;

public partial class Citas : ContentPage
{
		public ObservableCollection<Cita> lista = CitasVM.getCitas();
		
	public Citas()
	{
		InitializeComponent();

	}

	public async void onItemSelecter(object obj, SelectedItemChangedEventArgs select){

		DisplayAlert("AAAA", "aaaaa", "OK");
	}
}