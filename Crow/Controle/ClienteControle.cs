
using Crow.Modelos;

namespace Controles;

public class ClienteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ClienteControle() : base()
  {
    NomeDaTabela = "Clientes";
  }

  //----------------------------------------------------------------------------

  //public virtual Registro? Ler(int idCliente)
 // {
   // var collection = liteDB.GetCollection<User>(NomeDaTabela);
    //return collection.FindOne(d => d.Id == idCliente);
//  }

  //----------------------------------------------------------------------------

  public virtual List<User>? LerTodos()
  {
    var tabela = liteDB.GetCollection<User>(NomeDaTabela);
    return new List<User>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idCliente)
  {
    var collection = liteDB.GetCollection<User>(NomeDaTabela);
    collection.Delete(idCliente);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(User cliente)
  {
    var collection = liteDB.GetCollection<User>(NomeDaTabela);
    collection.Upsert(cliente);
  }

  //----------------------------------------------------------------------------
}