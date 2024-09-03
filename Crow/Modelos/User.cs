namespace Crow.Modelos;

public class User
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Telefone { get; set; }
    public string CPF { get; set; }
    public string Email{ get; set; }
    public string Password { get; set; }
    public int Data { get; set; }
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