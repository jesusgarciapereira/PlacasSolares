namespace PlacasSoladres.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evento asociado al pulsar el boton del LoginView, comprueba si los contenidos estan llenos, si lo estan avanza a la siguiente pagina
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="args"></param>
    private async void pulsarBoton(object obj, EventArgs args)
    {

        string correo = EntryUsu.Text;
        string contrasennia = EntryCon.Text;

        //Si alguno de los campos esta vacio
        if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasennia))
        {
            //Mostramos una ventana emergente comentado que tiene que rellenar los cambios
            DisplayAlert("Los campos no pueden estar vacios","Puedes escribir cualquier cosa, es sólo un ejemplo, no hay contraseñas ni nada","Ok");

        } 
        //En caso contrario
        else
        {   
            //Se dirige a la vista Citas
            await Navigation.PushAsync(new Citas());
        }
    }
}