namespace Crow
{
    public partial class EntradaPage : ContentPage
    {
        public EntradaPage()
        {
            InitializeComponent();
        }

        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            // Logic to open sidebar menu
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("AdicionarPage");
        }
    }
}
