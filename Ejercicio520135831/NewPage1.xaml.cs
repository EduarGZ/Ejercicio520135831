namespace Ejercicio520135831;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string verificar = personas.Text;

        if (string.IsNullOrWhiteSpace(verificar))
        {
            DisplayAlert("Error", "Por favor, ingrese un número de personas.", "Regresar");
        }
        else
        {
            int cantidadPersonas = Convert.ToInt32(personas.Text);
            int platillo = 95;
            int cantidadCobro = 0;

            if (cantidadPersonas > 200 && cantidadPersonas <= 300)
            {
                platillo = 85;
                cantidadCobro = cantidadPersonas * 85;
                indicar.Text = "El total de personas es: " + cantidadPersonas + " y el total seria de $" + cantidadCobro;
                mostrar.IsVisible = true;
            }
            else if (cantidadPersonas > 300)
            {
                platillo = 75;
                cantidadCobro = cantidadPersonas * 75;
                indicar.Text = "El total de personas es: " + cantidadPersonas + " y el total seria de $" + cantidadCobro;
                mostrar.IsVisible = true;
            }
            else
            {
                cantidadCobro = cantidadPersonas * 95;
                indicar.Text = "El total de personas es: " + cantidadPersonas + " y el total seria de $" + cantidadCobro;
                mostrar.IsVisible = true;
            }
        }

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_6(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Principal");
    }
}