using ControleDeContatos.Controllers;
using ControleDeContatos.Data;
using ControleDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ControleDeContatos.Repos
{
    public class UsuarioRepos : iUsuarioRepos
    {
        private readonly BancoContext _context;
        public UsuarioRepos(BancoContext bancoContext) 
        {
            this._context = bancoContext; 
        }

        public UsuarioModel BuscarPorLogin(string login)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel ListarPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _context.Usuarios.ToList();
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            // Gravar o banco de dados
            usuario.DataCadastro = DateTime.Now;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização do usuário!");

                usuarioDB.Nome = usuario.Nome;
                usuarioDB.Email = usuario.Email;
                usuarioDB.Login = usuario.Login;
                usuarioDB.Perfil= usuario.Perfil;
                usuarioDB.DataAtualizacao = DateTime.Now;     

                _context.Usuarios.Update(usuarioDB);
                _context.SaveChanges();

                return usuarioDB;
        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na deleção do usuário!");

            _context.Usuarios.Remove(usuarioDB);
            _context.SaveChanges();

            return true;
        }

        public UsuarioModel Adicionar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel Atualizar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
