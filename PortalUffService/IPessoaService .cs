using PortalUffRepository.Models;
using PortalUffService.Base;
using System.Collections.Generic;

namespace PortalUffService
{
    public interface IPessoaService : IService<Pessoa> { 

        List<Pessoa> Obter();

    }
}
