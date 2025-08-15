namespace Ejercicio520135831;

public partial class Jefferson2Page : ContentPage
{
	public Jefferson2Page()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Validación
        if (string.IsNullOrWhiteSpace(txtHoras.Text) ||
            string.IsNullOrWhiteSpace(txtPagoHora.Text))
        {
            DisplayAlert("Error", "Por favor ingrese todos los datos", "OK");
            return;
        }

        if (!double.TryParse(txtHoras.Text, out double horas) ||
            !double.TryParse(txtPagoHora.Text, out double pagoHora))
        {
            DisplayAlert("Error", "Ingrese solo números válidos", "OK");
            return;
        }

        // Cálculo
        double sueldo = horas * pagoHora;

        // Mostrar resultado
        lblResultado.Text = $"Sueldo semanal: ${sueldo:F2}";

        // Cambiar color según el sueldo
        if (sueldo < 150)
            frameResultado.BackgroundColor = Colors.LightCoral; // Rojo
        else if (sueldo <= 300)
            frameResultado.BackgroundColor = Colors.Khaki; // Amarillo
        else
            frameResultado.BackgroundColor = Colors.LightGreen; // Verde
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Principal");
    }
}