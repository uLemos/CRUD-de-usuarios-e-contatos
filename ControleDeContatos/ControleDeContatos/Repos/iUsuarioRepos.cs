using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repos
{
    public interface iUsuarioRepos
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos(); 
        UsuarioModel Adicionar(ContatoModel contato);
        UsuarioModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel BuscarPorID(int id);
        UsuarioModel Atualizar(UsuarioModel usuario);
    }
}
