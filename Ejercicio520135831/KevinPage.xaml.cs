namespace Ejercicio520135831;

public partial class KevinPage : ContentPage
{
	public KevinPage()
	{
		InitializeComponent();
	}

    private void btnOpciones_Clicked(object sender, EventArgs e)
    {
        // Alterna la visibilidad del menú de opciones
        frameOpciones.IsVisible = !frameOpciones.IsVisible;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            // Cambia el texto del botón principal según la opción seleccionada
            btnOpciones.Text = btn.Text;

            // Oculta el menú de opciones
            frameOpciones.IsVisible = false;
        }
    }

    private void btnOpciones2_Clicked(object sender, EventArgs e)
    {
        frameOpciones2.IsVisible = !frameOpciones2.IsVisible;

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (sender is Button bttn)
        {
            // Cambia el texto del botón principal según la opción seleccionada
            btnOpciones2.Text = bttn.Text;

            // Oculta el menú de opciones
            frameOpciones2.IsVisible = false;
        }
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        string verificar = cantidad.Text;
        
        if (string.IsNullOrWhiteSpace(verificar))
        {
            Resultado.Text = "Coloca la cantidad";
        }
        else if (btnOpciones.Text == "Pesos")
        {
            int cantidad1 = Convert.ToInt32(cantidad.Text);
            int Pesos = cantidad1;

            if (btnOpciones2.Text == "Dolares")
            {
                double resultado1 = Pesos * 0.054;
                Resultado.Text = resultado1.ToString() + " dolares";
            }
            else
            {
                Resultado.Text = Pesos.ToString() + " pesos";
            }
        }
        else if (btnOpciones.Text == "Dolares")
        {
            int cantidad1 = Convert.ToInt32(cantidad.Text);
            int dolares = cantidad1;

            if (btnOpciones2.Text == "Pesos")
            {
                double resultado2 = dolares * 18.61;
                Resultado.Text = resultado2.ToString() + " pesos";
            }
            else
            {
                Resultado.Text = dolares.ToString() + " dolares";
            }
        }

        }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Principal");
    }
}