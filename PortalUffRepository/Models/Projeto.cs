using PortalUffRepository.Models.Base;
using System;
using System.Collections.Generic;

namespace PortalUffRepository.Models
{
    public class Projeto: BaseModel
    {
        public string Titulo { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public Coordenador Coordenador { get; set; }

        public Equipe Equipe { get; set; }

        public Status Status { get; set; }

        public IList<ProjetoAssunto> ProjetoAssuntos { get; set; }
    }
}
