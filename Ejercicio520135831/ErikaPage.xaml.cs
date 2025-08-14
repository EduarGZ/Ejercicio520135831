namespace Ejercicio520135831;

public partial class ErikaPage : ContentPage
{
	public ErikaPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int contador = 10;
        lblCuenta.Text = contador.ToString();

        // Inicia un timer que se ejecuta cada 1 segundo
        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            contador--;

            if (contador > 0)
            {
                lblCuenta.Text = contador.ToString();
                return true; // sigue ejecutando
            }
            else
            {
                lblCuenta.Text = "¡Listo!";
                return false; // detiene el timer
            }
        });
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Principal");
    }
}