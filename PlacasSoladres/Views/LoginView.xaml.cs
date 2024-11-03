namespace PlacasSoladres.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private void botonPresionado(object obj, EventArgs args)
    {

        string correo = EntryUsu.Text;
        string contraseya = EntryCon.Text;

        if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseya))
        {



        }
    }
}