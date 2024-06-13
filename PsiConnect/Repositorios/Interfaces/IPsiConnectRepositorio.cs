using PsiConnect.Models;

namespace PsiConnect.Repositorios.Interfaces
{
    public interface IPsiConnectRepositorio
    {
        Usuario Cadastrar(Usuario usuario);
        Psicologos CadastrarPsi(Psicologos psicologos);
    }
}
