using PortalUffRepository.Models.Base;
using System.Collections;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class Coordenador: BaseModel
    {
        public Pessoa Pessoa { get; set; }

        public IList<Projeto> Projetos { get; set; }
    }
}
