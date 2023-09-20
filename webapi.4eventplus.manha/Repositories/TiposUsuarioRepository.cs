using webapi._4eventplus.manha.Contexts;
using webapi._4eventplus.manha.Domains;
using webapi._4eventplus.manha.Interfaces;

namespace webapi._4eventplus.manha.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public TiposUsuarioRepository() 
        {
          _eventContext= new EventContext();
        }

        public void Atualizar(Guid id, TiposUsuario tiposUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            _eventContext.TiposUsuario.Add(tiposUsuario);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
