using Controllers.Base;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class UsuariosController
    {
        private static List<Usuario> listaUsuarios { get; set; } = new List<Usuario>();

        private static int ultimoID = 1;

        //Add Usuario
        public void Adicionar(Usuario usuario)
        {
            usuario.UsuarioID = ultimoID++;
            listaUsuarios.Add(usuario);
        }

        //Listar Usuario
        public List<Usuario> ListarTodos()
        {
            return listaUsuarios;
        }

        //Buscar Usuário por ID
        public Usuario BuscarPorID(int id)
        {
            foreach (Usuario u in listaUsuarios)
            {
                if (u.UsuarioID == id)
                    return u;
            }
            return null;
        }

        //Buscar Usuário por Nome
        public List<Usuario> ListarPorNome(string nome)
        {
            List < Usuario > usuariosSelecionados = new List<Usuario>();
            foreach (Usuario u in listaUsuarios)
            {
                if (u.Nome.ToLower().Contains(nome.ToLower()))
                    usuariosSelecionados.Add(u);
            }
            return usuariosSelecionados;
        }

        //Buscar Usuário Ativo/Inativo
        public List<Usuario> ListarAtivo(bool ativo)
        {
            IEnumerable<Usuario> usuariosSelecionados = new List<Usuario>();
            usuariosSelecionados = from u in listaUsuarios where u.Ativo = ativo select u;

            return usuariosSelecionados.ToList();
        }
       
        //BuscarAtivoInativo
        public List<Atividade> BuscarAtivoInativo(bool ativo)
        {
            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();
            atividadesSelecionadas = from x in ListaAtividades where x.Ativo = ativo select x;

            return atividadesSelecionadas.ToList();
        }

        //Editar
        public void Editar(int id, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = BuscarPorID(id);

            if (atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }

        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorID(id);

            if (atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }
        }

        IList<Usuario> IBaseController<Usuario>.ListarTodos()
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarPorNome()
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
