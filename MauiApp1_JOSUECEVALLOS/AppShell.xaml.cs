namespace MauiApp1_JOSUECEVALLOS;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rutas para las páginas
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("AboutPage", typeof(AboutPage));
        Routing.RegisterRoute("InfoPage", typeof(InfoPage));
        Routing.RegisterRoute("ContactPage", typeof(ContactPage));
    }
}
