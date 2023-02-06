using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repos
{
    public interface iContatoRepos
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos(); 
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
