using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortalUffRepository;
using PortalUffRepository.Models;
using PortalUffRepository.Repository;
using PortalUffService.Base;
using System.Collections.Generic;
using System.Linq;

namespace PortalUffService
{
    public class PessoaService : Service<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(
            IMapper mapper,
            IHttpContextAccessor context,
            IPessoaRepository pessoaRepository
            ) : base(mapper, context, pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public List<Pessoa> Obter()
        {
            return _pessoaRepository.Obter().ToList();
        }
    }
}
