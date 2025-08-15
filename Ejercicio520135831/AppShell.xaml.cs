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
            Routing.RegisterRoute("Sexta", typeof(KevinPage));
            Routing.RegisterRoute("Tercera", typeof(JeffersonPage));
            Routing.RegisterRoute("Cuarta", typeof(Jefferson2Page));
        }
    }
}
