using Citas;

namespace PlacasSoladres.Views;

public partial class DetallesCitas : ContentPage
{
    public DetallesCitas(Cita cita)
    {
        InitializeComponent();
        BindingContext = cita;
    }
    /// <summary>
    /// Evento asociado al pulsar el boton Volver, vuelve a la pagina anterior
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="args"></param>
    private async void botonVolver(object obj, EventArgs args)
    {
        await Navigation.PopAsync();
    }

    /// <summary>
    /// Evento asociado al pulsar el boton Guardar, muestra el mensaje de que se ha guardado correctamente
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void botonGuardar(object sender, EventArgs e)
    {
        await DisplayAlert("Éxito", "Datos guardados correctamente", "OK");
    }

    /// <summary>
    /// Funcion que dependiendo del check escribe en el label si es apto o no
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="args"></param>
    public void aptoONo(object obj, CheckedChangedEventArgs args)
    {
        if (args.Value)
        {
            labelApto.Text = "Apto";
        }
        else
        {
            labelApto.Text = "No apto";
        }
    }
}