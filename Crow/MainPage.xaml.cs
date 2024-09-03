using Microsoft.Maui.Controls;

namespace Crow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}
