using Citas;

namespace PlacasSoladres.Views;

public partial class DetallesCitas : ContentPage
{
	public DetallesCitas(Cita cita)
	{
		InitializeComponent();
		BindingContext = cita;
	}


}