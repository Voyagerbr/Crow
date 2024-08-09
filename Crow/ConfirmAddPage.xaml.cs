using Microsoft.Maui.Controls;

namespace Crow
{
    public partial class ConfirmAddPage : ContentPage
    {
        public ConfirmAddPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Adicionar a conta à lista e voltar para a página principal
            Shell.Current.GoToAsync("//MainPage");
            // Adicionar lógica para adicionar o item à listaF
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Voltar para a página principal sem adicionar nada
            Shell.Current.GoToAsync("//MainPage");
        }
    }
}
