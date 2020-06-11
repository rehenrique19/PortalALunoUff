using PortalUffRepository.Models.Base;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class Equipe: BaseModel
    {
        public IList<Projeto> Projetos { get; set; }

        public IList<Aluno> Alunos { get; set; }
    }
}
