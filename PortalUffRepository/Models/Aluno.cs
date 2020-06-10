using PortalUffRepository.Models.Base;

namespace PortalUffRepository.Models
{
    public class Aluno: BaseModel
    {
        public Pessoa Pessoa { get; set; }
        public Equipe Equipe { get; set; }
    }
}
