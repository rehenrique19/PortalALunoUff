using System;

namespace PortalUffRepository.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }

        public string CriadoPor { get; set; }

        public DateTime CriadoEm { get; set; }

        public string ModifPor { get; set; }

        public DateTime? ModifEm { get; set; }

    }
}
