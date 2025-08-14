namespace Ejercicio520135831
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Primera", typeof(NewPage1));
        }
    }
}
