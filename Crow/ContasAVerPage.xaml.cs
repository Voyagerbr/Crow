namespace Crow
{
    public partial class ContasAVerPage : ContentPage
    {
        public ContasAVerPage()
        {
            InitializeComponent();
        }


        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            AddFrame.IsVisible = true;

        }

        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            MenuFrame.IsVisible = true;

            if (MenuFrame.IsVisible)
            {
                ItemsList.IsVisible = false;
            }

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

        private void Adicionar_Clicked(Object sender, EventArgs e)
        {
            //Não esquece de fazer essa merda
        }
        private void Cancelar_Clicked(Object sender, EventArgs e)
        {
             ItemsList.IsVisible = true;
            AddButton.IsVisible = true;
            MenuButton.IsVisible = true;
            MainLabel.IsVisible = true;
            AddFrame.IsVisible = false;
        }
    }

}

