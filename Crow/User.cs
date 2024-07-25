namespace Crow;

public class User
{
    string Nome;
    string Telefone;
    string CPF;
    string Email;
    string Password;
    public void SetNome(string Nome) {
        this.Nome = Nome;
    }
    public void SetEmail(string email){
        this.Email = Email;
    }
    public void SetPassword(string Password){
        this.Password = Password;
    }
    public void SetCPF(string CPF){
        this.CPF = CPF;
    }
   
    public string GetNome() {
        return Nome;
    }

      
}