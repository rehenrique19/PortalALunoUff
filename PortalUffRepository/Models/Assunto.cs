using PortalUffRepository.Models.Base;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class Assunto: BaseModel
    {
        public string Palavra { get; set; }

        public IList<ProjetoAssunto> ProjetoAssuntos { get; set; }
    }
}
