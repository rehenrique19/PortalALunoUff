using Microsoft.AspNetCore.Mvc;
using PortalAlunoWeb.Controllers.Base;
using PortalUffService;
using System;

namespace PortalAlunoWeb.Controllers
{

    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class PessoaController: BaseController
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(
            IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public IActionResult Obter()
        {
            try
            {
                return Ok(_pessoaService.Obter());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
