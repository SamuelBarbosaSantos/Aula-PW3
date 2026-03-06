using Samuel_e_Linerker.Models;

namespace Samuel_e_Linerker.Repository.Contract
{
    public interface IUsuarioRepository
    {
        //CRUD
        IEnumerable <Usuario> ObterTododsUsarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int id);

        void Excluir(int id);



    }
}
