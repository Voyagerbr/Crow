using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class ConfirmRemovePage : ContentPage
    {
        public ConfirmRemovePage()
        {
            InitializeComponent();
        }

        private void OnRemoveClicked(object sender, EventArgs e)
        {
            // Remover a conta da lista e voltar para a página principal
            Shell.Current.GoToAsync("//MainPage");
            // Adicionar lógica para remover o item da lista
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            // Voltar para a página principal sem remover nada
            Shell.Current.GoToAsync("//MainPage");
        }
    }
}
