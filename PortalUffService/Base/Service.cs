using AutoMapper;
using Microsoft.AspNetCore.Http;
using PortalUffRepository;
using PortalUffRepository.Repository.Base;

namespace PortalUffService.Base
{
    public abstract class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly IHttpContextAccessor _context;
        private IHttpContextAccessor context;

        public Service(IMapper mapper, IHttpContextAccessor context, IRepository<T> repository = null)
        {
            Mapper = mapper;
            _repository = repository;
            _context = context;
        }

        protected IMapper Mapper { get; }
    }
}
