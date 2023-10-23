using CepAPI.Integracoes.Response;

namespace CepAPI.Integracoes.Interfaces
{
    public interface ICepIntegracao
    {
        Task<CepResponse> ObterDadosCep(string cep);
    }
}
