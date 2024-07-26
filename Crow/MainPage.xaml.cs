using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Navegar para a página de remoção
            Shell.Current.GoToAsync("//ConfirmRemovePage");
        }

        private void OnCheckClicked(object sender, EventArgs e)
        {
            // Lógica para marcar uma conta como paga e remover da lista
            // Atualizar a lista de contas
            DisplayAlert("Pago", "Conta marcada como paga", "OK");
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Navegar para a página de adicionar
            Shell.Current.GoToAsync("//AddPage");
        }
    }
}


