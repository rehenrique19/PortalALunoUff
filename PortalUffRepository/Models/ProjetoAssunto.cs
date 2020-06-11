using PortalUffRepository.Models.Base;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class ProjetoAssunto: BaseModel
    {
        public Projeto Projeto { get; set; }

        public Assunto Assunto { get; set; }

    }
}
