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
            MenuFrame.IsVisible = !MenuFrame.IsVisible;
        }
        private void BackClicked(object sender, EventArgs e)
        {
            MenuFrame.IsVisible = false;
        }
        private void EntradaButtonIsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntradaPage());
        }
        private void SaidaButtonIsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SaidaPage());
        }
         private void ContasAReceberButtonIsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContasAReceberPage());
        }
         private void ContasAVerButtonIsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContasAVerPage());
        }
        private void CadastroClienteButtonIsClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroClientePage());
        }
    }
}
