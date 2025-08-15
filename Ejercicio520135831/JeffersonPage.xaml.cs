namespace Ejercicio520135831;

public partial class JeffersonPage : ContentPage
{
	public JeffersonPage()
	{
		InitializeComponent();

        CargarTablas();

    }

    private void CargarTablas()
    {
        // Llenar el Picker con opciones del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            TablaPicker.Items.Add($"Tabla del {i}");
        }
    }

    private void TablaPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (TablaPicker.SelectedIndex == -1)
            return;

        int numero = TablaPicker.SelectedIndex + 1;
        MostrarTabla(numero);
    }

    private void MostrarTabla(int numero)
    {
        string textoTabla = $"Tabla del {numero}\n\n";

        for (int j = 1; j <= 10; j++)
        {
            textoTabla += $"{numero} x {j} = {numero * j}\n";
        }

        ResultadoLabel.Text = textoTabla;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Principal");
    }
}