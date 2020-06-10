using PortalUffRepository.Models;
using PortalUffRepository.Repository.Base;
using System.Linq;
namespace PortalUffRepository.Repository
{
    public interface IPessoaRepository: IRepository<Pessoa>
    {
        IQueryable<Pessoa> Obter();
    }
}
