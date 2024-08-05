namespace YourNamespace
{
    public partial class ContasAVerPage : ContentPage
    {
        public ContasAVerPage()
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
