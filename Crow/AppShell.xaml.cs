namespace Crow;

{
    public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        
        Routing.RegisterRoute("HomePage", typeof(HomePage));
        
        Routing.RegisterRoute("EntradaPage", typeof(EntradaPage));
        
        Routing.RegisterRoute("SaidaPage", typeof(SaidaPage));
        
        Routing.RegisterRoute("ContasAVerPage", typeof(ContasAVerPage));
        
        Routing.RegisterRoute("ContasAReceberPage", typeof(ContasAReceberPage));
        
        Routing.RegisterRoute("AdicionarPage", typeof(AdicionarPage));
        
        Routing.RegisterRoute("RemoverPage", typeof(RemoverPage));
        
        Routing.RegisterRoute("ConfirmAddPage", typeof(ConfirmAddPage));
        
        Routing.RegisterRoute("ConfirmRemoverPage", typeof(ConfirmRemoverPage));
        
    }
}
}

