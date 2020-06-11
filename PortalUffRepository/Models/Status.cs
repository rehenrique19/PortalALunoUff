using PortalUffRepository.Models.Base;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class Status: BaseModel
    {
        public string Nome { get; set; }

        public IList<Projeto> Projetos { get; set; }
    }
}
