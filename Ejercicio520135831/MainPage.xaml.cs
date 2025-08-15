namespace Ejercicio520135831
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Segunda");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Quinta");
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Sexta");
        }
    }

}
