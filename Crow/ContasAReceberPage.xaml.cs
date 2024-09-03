using Crow.Modelos;

namespace Crow
{
    public partial class ContasAReceberPage : ContentPage
    {
        //
        public User cliente { get; set; }
        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        Controles.EstadoControle estadoControle = new Controles.EstadoControle();

        //



        public ContasAReceberPage()
        {
            InitializeComponent();
        }


        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            ItemsList.IsVisible = false;
            AddButton.IsVisible = false;
            MenuButton.IsVisible = false;
            MainLabel.IsVisible = false;
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


        private void Cancelar_Clicked(Object sender, EventArgs e)
        {
            ItemsList.IsVisible = true;
            AddButton.IsVisible = true;
            MenuButton.IsVisible = true;
            MainLabel.IsVisible = true;
            AddFrame.IsVisible = false;
        }
        private async void Adicionar_Clicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
            {
                // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
                var cliente = new Modelos.User();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.Id = int.Parse(IdLabel.Text);
                else
                    cliente.Id = 0;
                cliente.Nome = NomeEntry.Text;
                cliente.Sobrenome = SobrenomeEntry.Text;

                // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
                clienteControle.CriarOuAtualizar(cliente);
                // Mostra a mensagem de sucesso
                await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }
        
        private async Task<bool> VerificaSeDadosEstaoCorretos()
  {
    // Verifica se a Entry do Nome está vazia
    if (String.IsNullOrEmpty(NomeEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Sobrenome está vazia
    else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Telefone está vazia
    else
      return true;
  }


    }

}


