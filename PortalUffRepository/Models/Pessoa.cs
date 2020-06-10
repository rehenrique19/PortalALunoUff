using PortalUffRepository.Models.Base;

namespace PortalUffRepository.Models
{
    public class Pessoa: BaseModel
    {
        public string Email { get; set; }
        public string Nome { get; set; }
    }
}
