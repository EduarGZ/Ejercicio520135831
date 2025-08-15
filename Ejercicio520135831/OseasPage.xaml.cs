namespace Ejercicio520135831;

public partial class OseasPage : ContentPage
{
	public OseasPage()
	{
		InitializeComponent();


        List<int> numerosPares = new();

        for (int i = 0; i <= 100; i += 2)
        {
            numerosPares.Add(i);
        }

        NumerosParesCollection.ItemsSource = numerosPares;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Principal");
    }
}