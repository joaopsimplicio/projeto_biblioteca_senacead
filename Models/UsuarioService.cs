using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public List<Usuario> Listar() {
            using (BibliotecaContext bc = new BibliotecaContext()) {
                return bc.Usuarios.ToList();
            }
        }

        public Usuario Listar(int id) {
            using (BibliotecaContext bc = new BibliotecaContext()) {
                return bc.Usuarios.Find(id);
            }
        }

        public void Inserir(Usuario user) {
            using (BibliotecaContext bc = new BibliotecaContext()) {
                bc.Usuarios.Add(user);
                bc.SaveChanges();
            }
        }

        public void Editar(Usuario userEdit) {
            using (BibliotecaContext bc = new BibliotecaContext()) {
                Usuario u = bc.Usuarios.Find(userEdit.Id);
                u.Nome = userEdit.Nome;
                u.Login = userEdit.Login;
                u.Senha = userEdit.Senha;
                u.Tipo = userEdit.Tipo;
            }
        }

        public void Excluir(int id) {
            using (BibliotecaContext bc = new BibliotecaContext()) {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
            }
        }

        public Usuario ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }
    }
}