using PortalUffRepository.Models.Base;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class Pessoa: BaseModel
    {
        public string Email { get; set; }

        public string Nome { get; set; }

        public IList<Coordenador> Coordenadores { get; set; }

        public IList<Aluno> Alunos { get; set; }
    }
}
