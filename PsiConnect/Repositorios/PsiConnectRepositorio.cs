using PsiConnect.Context;
using PsiConnect.Models;
using PsiConnect.Repositorios.Interfaces;

namespace PsiConnect.Repositorios
{
    public class PsiConnectRepositorio : IPsiConnectRepositorio
    {
        private readonly AppDbContext _appDbContext;
        public PsiConnectRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Usuario Cadastrar(Usuario usuario)
        {
            _appDbContext.Usuarios.Add(usuario);
            _appDbContext.SaveChanges();
            return usuario;
        }

        public Prontuario CadastrarProntuario(Prontuario prontuario)
        {
            _appDbContext.Prontuarios.Add(prontuario);
            _appDbContext.SaveChanges ();
            return prontuario;
        }

        public Psicologos CadastrarPsi(Psicologos psicologos)
        {
            _appDbContext.Psicologos.Add(psicologos);
            _appDbContext.SaveChanges();
            return psicologos;
        }


    }
}
