namespace Ejercicio520135831
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Segunda", typeof(ErikaPage));
            Routing.RegisterRoute("Principal", typeof(MainPage));
            Routing.RegisterRoute("Quinta", typeof(NewPage1));
        }
    }
}
