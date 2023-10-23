
using CepAPI.Integracoes.Interfaces;
using CepAPI.Integracoes.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ICepIntegracao _cepIntegracao;

        public CepController(ICepIntegracao cepIntegracao)
        {
            _cepIntegracao = cepIntegracao;
        }

        [HttpGet]
        public async Task<ActionResult<CepResponse>> ListarDadosEndereco(string cep) 
        {
            var result = await _cepIntegracao.ObterDadosCep(cep);

            if(result == null) 
            {
                return BadRequest("Cep Não Encontrado.");
            }

            return Ok(result);
        }
    }
}
