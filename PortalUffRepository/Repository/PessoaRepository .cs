using Microsoft.EntityFrameworkCore;
using PortalUffRepository.Models;
using PortalUffRepository.Repository.Base;
using System.Linq;
using PortalUffRepository.Contexto;

namespace PortalUffRepository.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        private readonly DbContext _contexto;

        public PessoaRepository(PortalContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<Pessoa> Obter()
        {
           return GetAllAsQuery();
        }
    }
}
