using Microsoft.Maui.Controls;

namespace Crow
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            SidebarExpander.IsExpanded = !SidebarExpander.IsExpanded;
        }

        private async void OnEntradaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntradaPage());
        }

        private async void OnSaidaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SaidaPage());
        }

        private async void OnContasAVerClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContasAVerPage());
        }

        private async void OnContasAReceberClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContasAReceberPage());
        }
    }
}
