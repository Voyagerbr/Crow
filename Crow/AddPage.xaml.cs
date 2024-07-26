using Microsoft.Maui.Controls;

namespace Crow
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void OnConfirmAddClicked(object sender, EventArgs e)
        {
            // Navegar para a página de confirmação de adição
            Shell.Current.GoToAsync("//ConfirmAddPage");
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Voltar para a página principal sem adicionar nada
            Shell.Current.GoToAsync("//MainPage");
        }
    }
}
